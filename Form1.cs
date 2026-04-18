using MaterialSkin;
namespace MetaTag;

public partial class Form1 : Form
{
    private readonly MaterialSkinManager materialSkinManager;
    private string[] supportedFilesExtensions = new string[] { "mp3" };
    private string[] supportedImageExtensions = new string[] { "jpg", "jpeg", "png", "bmp", "gif" };
    public string CurrentFilePath;
    public string CurrentImageFilePath;
    public Image imageFile;

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
                imageFile = Image.FromFile(imageFilePath);
                ImagePreviewPanel.BackgroundImage = imageFile;
                ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Zoom;
                CurrentImageFilePath = imageFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image:: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        if (!string.IsNullOrEmpty(audioFilePath))
        {
            FileNameLabel.Text = Path.GetFileName(audioFilePath);
            CurrentFilePath = audioFilePath;

            MarkAsUnsaved(null, null);

            SetTagsLabels(tagController.LoadTagData(CurrentFilePath));
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

    private void SetTagsLabels(TagController.TagData data)
    {
        string artistCombinedString = "";
        string genreCombinedString = "";

        artistCombinedString = string.Join(",", data.Performers);
        genreCombinedString = string.Join(",", data.Genres);

        TitleTextField.Text = data.Title;
        ArtistTextField.Text = artistCombinedString;
        AlbumTextField.Text = data.Album;
        GenreTextField.Text = genreCombinedString;
        YearTextField.Text = data.Year;
        TrackNumTextField.Text = data.TrackCount;
        CommentTextField.Text = data.Comment;
        BPMTextField.Text = data.BPM;
        KeyTextField.Text = data.Key;
        TuningForkTextField.Text = data.Tune;

        SetBackgroundFromTag(data);
    }

    private void SetBackgroundFromTag(TagController.TagData data)
    {
        if (ImagePreviewPanel.BackgroundImage?.Tag?.ToString() != "Resource")
        {
            ImagePreviewPanel.BackgroundImage?.Dispose();
        }

        ImagePreviewPanel.BackgroundImage = data.CoverImage;
        ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Zoom;
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
            imageFile = Image.FromFile(imagePath);
            ImagePreviewPanel.BackgroundImage = imageFile;
            ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Zoom;
            CurrentImageFilePath = imagePath;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load image:: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        if (string.IsNullOrEmpty(CurrentFilePath)) 
        { MessageBox.Show($"Please load a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

        TagController.SaveResult saveResult = new(false, string.Empty);
        if (ImagePreviewPanel.BackgroundImage?.Tag?.ToString() == "Resource")
        {
            saveResult = tagController.SaveFileTags(CurrentFilePath, CurrentImageFilePath, TitleTextField.Text, ArtistTextField.Text, AlbumTextField.Text, GenreTextField.Text, YearTextField.Text, TrackNumTextField.Text, BPMTextField.Text, KeyTextField.Text, TuningForkTextField.Text, CommentTextField.Text, (Image)resources.GetObject("ImagePreviewPanel.BackgroundImage"));
        }
        else
        {   
            if (imageFile != null) saveResult = tagController.SaveFileTags(CurrentFilePath, CurrentImageFilePath, TitleTextField.Text, ArtistTextField.Text, AlbumTextField.Text, GenreTextField.Text, YearTextField.Text, TrackNumTextField.Text, BPMTextField.Text, KeyTextField.Text, TuningForkTextField.Text, CommentTextField.Text, imageFile);
            else saveResult = tagController.SaveFileTags(CurrentFilePath, CurrentImageFilePath, TitleTextField.Text, ArtistTextField.Text, AlbumTextField.Text, GenreTextField.Text, YearTextField.Text, TrackNumTextField.Text, BPMTextField.Text, KeyTextField.Text, TuningForkTextField.Text, CommentTextField.Text, ImagePreviewPanel.BackgroundImage);
        }
        
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