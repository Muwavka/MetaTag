using System.Drawing.Imaging;
using TagLib;

namespace MetaTag
{
    internal class TagController
    {   
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
                    if (!uint.TryParse(year, out uint fileYear)) { return new SaveResult(false, "Ошибка в поле Year"); }
                    file.Tag.Year = fileYear;
                    if (!uint.TryParse(trackCount, out uint _trackCount)) { return new SaveResult(false, "Ошибка в поле Track Count"); }
                    file.Tag.Track = _trackCount;


                    string finalComment = "";

                    if (!string.IsNullOrEmpty(bpm)) 
                    { 
                        if (uint.TryParse(bpm, out uint _bpm)) file.Tag.BeatsPerMinute = _bpm;
                    }
                    if (!string.IsNullOrEmpty(key))
                    {
                        file.Tag.InitialKey = key;
                    }
                    if (!string.IsNullOrEmpty(tune) && tune != "440") finalComment += $"Tune: {tune}Hz";
                    if (!string.IsNullOrEmpty(comment)) finalComment += $"  {comment}";

                    file.Tag.Comment = finalComment;

                    if (!string.IsNullOrEmpty(imageFilePath) && System.IO.File.Exists(imageFilePath))
                    {
                        file.Tag.Pictures = new TagLib.IPicture[] { new TagLib.Picture(imageFilePath) };
                    }
                    else
                    {
                        if (defaultImg != null)
                        {
                            using (var ms = new MemoryStream())
                            {
                                defaultImg.Save(ms, ImageFormat.Png);
                                ms.Position = 0;
                                var picture = new TagLib.Picture(new TagLib.ByteVector(ms.ToArray()));
                                picture.MimeType = "image/png";
                                picture.Type = TagLib.PictureType.FrontCover;
                                file.Tag.Pictures = new[] { picture };
                            }
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
    }
}
