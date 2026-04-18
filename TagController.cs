using System.Drawing.Imaging;
using System.Text;

namespace MetaTag
{
    internal class TagController
    {
        public class TagData
        {
            public string Title { get; set; }
            public string[] Performers { get; set; }
            public string Album { get; set; }
            public string[] Genres { get; set; }
            public string Year { get; set; }
            public string TrackCount { get; set; }
            public string Comment { get; set; }
            public string BPM { get; set; }
            public string Tune { get; set; }
            public string Key { get; set; }
            public Image CoverImage { get; set; }
        }
        public class SaveResult
        {
            public bool Success;
            public string Message;
            public SaveResult(bool Success, string Message)
            {
                this.Success = Success;
                this.Message = Message;
            }
        }
        public SaveResult SaveFileTags(string filePath, string imageFilePath, string title, string artists, string album, string genres, string year, string trackCount, string bpm, string key, string tune, string comment, Image defaultImg)
        {
            try
            {
                using (var file = TagLib.File.Create(filePath))
                {
                    file.Tag.Title = title;
                    file.Tag.Performers = new string[] { artists };
                    file.Tag.Album = album;
                    file.Tag.Genres = new string[] { genres };
                    if (!uint.TryParse(year, out uint fileYear)) { return new SaveResult(false, "Error in Year field!"); }
                    file.Tag.Year = fileYear;
                    if (!uint.TryParse(trackCount, out uint _trackCount)) { return new SaveResult(false, "Error in Track Count field!"); }
                    file.Tag.Track = _trackCount;

                    if (!string.IsNullOrEmpty(tune) && tune != "440")
                    {
                        var id3v2Tag = file.GetTag(TagLib.TagTypes.Id3v2, true) as TagLib.Id3v2.Tag;

                        var customFrame = TagLib.Id3v2.UserTextInformationFrame.Get(
                            id3v2Tag, "TUNE", true);
                        customFrame.Text = new[] { tune };
                    }


                    string finalComment = comment ?? "";

                    if (!string.IsNullOrEmpty(bpm)) 
                    { 
                        if (uint.TryParse(bpm, out uint _bpm)) file.Tag.BeatsPerMinute = _bpm;
                    }
                    if (!string.IsNullOrEmpty(key))
                    {
                        file.Tag.InitialKey = key;
                    }
                    if (!string.IsNullOrEmpty(comment)) file.Tag.Comment = comment;

                    if (!string.IsNullOrEmpty(tune) && tune != "440") file.Tag.Comment = $"Tuning fork: {tune}Hz; {finalComment}";
                    else file.Tag.Comment = comment;

                    if (!string.IsNullOrEmpty(imageFilePath) && File.Exists(imageFilePath))
                    {
                        var picture = new TagLib.Picture(imageFilePath);
                        picture.Type = TagLib.PictureType.FrontCover;
                        file.Tag.Pictures = new[] { picture };
                    }
                    else if (defaultImg != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            using (var safeBitmap = new Bitmap(defaultImg.Width, defaultImg.Height, PixelFormat.Format32bppArgb))
                            {
                                using (var g = Graphics.FromImage(safeBitmap))
                                {
                                    g.DrawImage(defaultImg, 0, 0, defaultImg.Width, defaultImg.Height);
                                }

                                var encoder = ImageCodecInfo.GetImageEncoders()
                                    .FirstOrDefault(c => c.FormatID == ImageFormat.Png.Guid);
                                var encoderParams = new EncoderParameters(1);
                                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);

                                safeBitmap.Save(ms, encoder ?? GetPngEncoder(), encoderParams);
                            }

                            ms.Position = 0;
                            var picture = new TagLib.Picture(new TagLib.ByteVector(ms.ToArray()));
                            picture.MimeType = "image/png";
                            picture.Type = TagLib.PictureType.FrontCover;
                            file.Tag.Pictures = new[] { picture };
                        }
                    }
                    file.Save();
                    return new SaveResult(true, "");
                }
            }
            catch (Exception ex)
            {
                return new SaveResult(false, ex.ToString());
            }
        }

        public TagData LoadTagData(string filePath)
        {
            using (var file = TagLib.File.Create(filePath))
            {
                string tune = null;
                var id3v2Tag = file.GetTag(TagLib.TagTypes.Id3v2) as TagLib.Id3v2.Tag;
                if (id3v2Tag != null)
                {
                    var tuneFrame = TagLib.Id3v2.UserTextInformationFrame.Get(
                        id3v2Tag, "TUNE", false);
                    if (tuneFrame != null && tuneFrame.Text.Length > 0)
                        tune = tuneFrame.Text[0];
                }

                var tagData = new TagData
                {
                    Title = file.Tag.Title,
                    Performers = file.Tag.Performers,
                    Album = file.Tag.Album,
                    Genres = file.Tag.Genres,
                    Year = file.Tag.Year.ToString(),
                    TrackCount = file.Tag.TrackCount.ToString(),
                    Comment = file.Tag.Comment,
                    BPM = file.Tag.BeatsPerMinute.ToString(),
                    Key = file.Tag.InitialKey,
                    Tune = tune,
                    CoverImage = ExtractCoverImage(file)
                };

                return tagData;
            }
        }
        private Image ExtractCoverImage(TagLib.File file)
        {
            if (file.Tag.Pictures.Length > 0)
            {
                var bin = file.Tag.Pictures[0].Data.Data;
                using var ms = new MemoryStream(bin);
                return new Bitmap(ms);
            }
            return null;
        }

        private static ImageCodecInfo GetPngEncoder()
        {
            return ImageCodecInfo.GetImageEncoders()
                .FirstOrDefault(c => c.FormatID == ImageFormat.Png.Guid);
        }
    }
}
