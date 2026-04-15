using MaterialSkin;
namespace MetaTag;

public partial class Form1 : Form
{
    private readonly MaterialSkinManager materialSkinManager;
    private string[] supportedFilesExtensions = new string[] { "mp3" };
    private string[] supportedImageExtensions = new string[] { "jpg", "jpeg", "png", "bmp", "gif" };
    public string CurrentFilePath;
    public string CurrentImageFilePath;

    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

    TagController tagController = new();

    public Form1()
    {
        InitializeComponent();
        this.AllowDrop = true;
        DropPanel.AllowDrop = true;
        ImagePreviewPanel.AllowDrop = true;
        SetRoundedShape(DropPanel, 30);
        SetRoundedShape(ImagePreviewPanel, 10);

        var textBoxes = new[] { TitleTextField, ArtistTextField, AlbumTextField, GenreTextField, YearTextField, TrackNumTextField, CommentTextField, BPMTextField, KeyTextField, TuningForkTextField};

        foreach (var tb in textBoxes)
        {
            tb.TextChanged += MarkAsUnsaved;
            SetRoundedShape(tb, 10);
        }

        materialSkinManager = MaterialSkinManager.Instance;

        SaveLabel.ForeColor = Color.Red;
        SaveLabel.Text = "";
        YearTextField.Text = DateTime.Now.Year.ToString();
    }
    static void SetRoundedShape(Control control, int radius)
    {
        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
        path.AddLine(radius, 0, control.Width - radius, 0);
        path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
        path.AddLine(control.Width, radius, control.Width, control.Height - radius);
        path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
        path.AddLine(control.Width - radius, control.Height, radius, control.Height);
        path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
        path.AddLine(0, control.Height - radius, 0, radius);
        path.AddArc(0, 0, radius, radius, 180, 90);
        control.Region = new Region(path);
    }
    private void PlusBpmLabelBut_Click_1(object sender, EventArgs e)
    {
        try
        {
            int currentBpmInField = int.Parse(BPMTextField.Text);
            BPMTextField.Text = $"{++currentBpmInField}";
        }
        catch { }
    }

    private void MinusBpmLabelBut_Click(object sender, EventArgs e)
    {
        try
        {
            int currentBpmInField = Convert.ToInt32(BPMTextField.Text);
            if (currentBpmInField <= 0) currentBpmInField = 0;
            else BPMTextField.Text = $"{--currentBpmInField}";
        }
        catch { }
    }

    private void DropPanel_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
    {
        DropPanel.BackColor = Color.FromArgb(255, 255, 255);

        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Copy;
        else
            e.Effect = DragDropEffects.None;
    }
    private void DropPanel_DragLeave(object sender, EventArgs e)
    {
        DropPanel.BackColor = Color.FromArgb(227, 227, 227);
    }

    private void DropPanel_DragDrop(object sender, DragEventArgs e)
    {
        if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            return;

        MarkAsUnsaved(null, null);

        DropPanel.BackColor = Color.FromArgb(227, 227, 227);
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        string audioFilePath = files.FirstOrDefault(f =>
            supportedFilesExtensions.Contains(Path.GetExtension(f).TrimStart('.').ToLower()));

        string imageFilePath = files.FirstOrDefault(f =>
            supportedImageExtensions.Contains(Path.GetExtension(f).TrimStart('.').ToLower()));

        if (!string.IsNullOrEmpty(imageFilePath))
        {
            if (ImagePreviewPanel.BackgroundImage?.Tag?.ToString() != "Resource")
            {
                ImagePreviewPanel.BackgroundImage?.Dispose();
            }

            try
            {
                Image img = Image.FromFile(imageFilePath);
                ImagePreviewPanel.BackgroundImage = img;
                ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Zoom;
                CurrentImageFilePath = imageFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        if (!string.IsNullOrEmpty(audioFilePath))
        {
            FileNameLabel.Text = Path.GetFileName(audioFilePath);
            CurrentFilePath = audioFilePath;

            MarkAsUnsaved(null, null);

            using (var file = TagLib.File.Create(audioFilePath))
            {
                SetTagsLabels(
                    file.Tag.Title,
                    file.Tag.Performers,
                    file.Tag.Album,
                    file.Tag.Genres,
                    file.Tag.Year.ToString(),
                    file.Tag.TrackCount.ToString(),
                    file.Tag.Comment
                );
                SetBackgroundFromTag(file);
            }
        }
        else if (!string.IsNullOrEmpty(imageFilePath))
        {
        }
        else
        {
            FileNameLabel.Text = "Unsupported format!";
            ImagePreviewPanel.BackgroundImage = (Image)resources.GetObject("ImagePreviewPanel.BackgroundImage");
            ImagePreviewPanel.BackgroundImage.Tag = "Resource";
            CurrentImageFilePath = null;
        }
    }

    private void SetTagsLabels(string title, string[] artists, string album, string[] genres, string year, string trackNumber, string comment)
    {
        string artistCombinedString = "";
        string genreCombinedString = "";
        foreach (string artist in artists)
        {
            artistCombinedString += $"{artist}";
        }

        foreach (string genre in genres)
        {
            genreCombinedString += $"{genre}";
        }

        TitleTextField.Text = title;
        ArtistTextField.Text = artistCombinedString;
        AlbumTextField.Text = album;
        GenreTextField.Text = genreCombinedString;
        YearTextField.Text = year;
        TrackNumTextField.Text = trackNumber;
        CommentTextField.Text = comment;
    }

    public void SetBackgroundFromTag(TagLib.File file)
    {
        if (file.Tag.Pictures.Length > 0)
        {
            var bin = file.Tag.Pictures[0].Data.Data;

            using (MemoryStream ms = new MemoryStream(bin))
            {
                ImagePreviewPanel.BackgroundImage?.Dispose();

                ImagePreviewPanel.BackgroundImage = Image.FromStream(ms);
                ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
    }

    private void ImagePreviewPanel_DragDrop(object sender, DragEventArgs e)
    {
        if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            return;

        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length == 0)
            return;

        string imagePath = null;
        foreach (string f in files)
        {
            string ext = Path.GetExtension(f).TrimStart('.').ToLower();
            if (supportedImageExtensions.Contains(ext))
            {
                imagePath = f;
                break;
            }
        }

        if (imagePath == null)
            return;

        if (ImagePreviewPanel.BackgroundImage != null)
        {
            if (ImagePreviewPanel.BackgroundImage.Tag?.ToString() != "Resource")
            {
                ImagePreviewPanel.BackgroundImage.Dispose();
            }
        }

        try
        {
            Image img = Image.FromFile(imagePath);
            ImagePreviewPanel.BackgroundImage = img;
            ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Zoom;
            CurrentImageFilePath = imagePath;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось загрузить изображение: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ImagePreviewPanel_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string ext = Path.GetExtension(files[0]).TrimStart('.').ToLower();
                if (supportedImageExtensions.Contains(ext))
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
        }
        e.Effect = DragDropEffects.None;
    }

    

    private void SaveBut_Click(object sender, EventArgs e)
    {
        var saveResult = tagController.SaveFileTags(CurrentFilePath, CurrentImageFilePath, TitleTextField.Text, ArtistTextField.Text, AlbumTextField.Text, GenreTextField.Text, YearTextField.Text, TrackNumTextField.Text, BPMTextField.Text, KeyTextField.Text, TuningForkTextField.Text, CommentTextField.Text, (Image)resources.GetObject("ImagePreviewPanel.BackgroundImage"));
        if (saveResult.Success)
        {
            MarkAsSaved(null, null);
        }
        else
        {
            MessageBox.Show($"Save error: {saveResult.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void MarkAsUnsaved(object sender, EventArgs e)
    {
        SaveLabel.Text = "Unsaved";
        SaveLabel.ForeColor = Color.Red;
    }
    private void MarkAsSaved(object sender, EventArgs e)
    {
        SaveLabel.Text = "Saved";
        SaveLabel.ForeColor = Color.Green;
    }
}