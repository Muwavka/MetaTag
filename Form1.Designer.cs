namespace MetaTag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SaveBut = new MaterialSkin.Controls.MaterialButton();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            DropPanel = new Panel();
            ImagePreviewPanel = new Panel();
            TitleTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            label2 = new Label();
            ArtistTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label3 = new Label();
            BPMTextField = new MaterialSkin.Controls.MaterialTextBox2();
            FileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            PlusBpmLabelBut = new Button();
            MinusBpmLabelBut = new Button();
            label4 = new Label();
            TuningForkTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label5 = new Label();
            YearTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label6 = new Label();
            KeyTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label7 = new Label();
            AlbumTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label8 = new Label();
            GenreTextField = new MaterialSkin.Controls.MaterialTextBox2();
            label9 = new Label();
            TrackNumTextField = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox1 = new GroupBox();
            CommentTextField = new MaterialSkin.Controls.MaterialTextBox2();
            SaveLabel = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveBut
            // 
            SaveBut.AutoSize = false;
            SaveBut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBut.BackColor = SystemColors.AppWorkspace;
            SaveBut.Cursor = Cursors.Hand;
            SaveBut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveBut.Depth = 0;
            SaveBut.HighEmphasis = true;
            SaveBut.Icon = null;
            SaveBut.Location = new Point(20, 507);
            SaveBut.Margin = new Padding(4, 6, 4, 6);
            SaveBut.MouseState = MaterialSkin.MouseState.HOVER;
            SaveBut.Name = "SaveBut";
            SaveBut.NoAccentTextColor = Color.Empty;
            SaveBut.Size = new Size(388, 50);
            SaveBut.TabIndex = 0;
            SaveBut.Text = "save";
            SaveBut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveBut.UseAccentColor = false;
            SaveBut.UseVisualStyleBackColor = false;
            SaveBut.Click += SaveBut_Click;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-250, 142);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(250, 120);
            materialDrawer1.TabIndex = 1;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // DropPanel
            // 
            DropPanel.AllowDrop = true;
            DropPanel.BackColor = SystemColors.ControlLight;
            DropPanel.BackgroundImage = (Image)resources.GetObject("DropPanel.BackgroundImage");
            DropPanel.BackgroundImageLayout = ImageLayout.Zoom;
            DropPanel.ForeColor = SystemColors.Control;
            DropPanel.Location = new Point(12, 12);
            DropPanel.Name = "DropPanel";
            DropPanel.Size = new Size(407, 79);
            DropPanel.TabIndex = 2;
            DropPanel.DragDrop += DropPanel_DragDrop;
            DropPanel.DragEnter += DropPanel_DragEnter;
            DropPanel.DragLeave += DropPanel_DragLeave;
            // 
            // ImagePreviewPanel
            // 
            ImagePreviewPanel.AllowDrop = true;
            ImagePreviewPanel.BackgroundImage = (Image)resources.GetObject("ImagePreviewPanel.BackgroundImage");
            ImagePreviewPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ImagePreviewPanel.Location = new Point(12, 112);
            ImagePreviewPanel.Name = "ImagePreviewPanel";
            ImagePreviewPanel.Size = new Size(100, 100);
            ImagePreviewPanel.TabIndex = 4;
            ImagePreviewPanel.DragDrop += ImagePreviewPanel_DragDrop;
            ImagePreviewPanel.DragEnter += ImagePreviewPanel_DragEnter;
            // 
            // TitleTextField
            // 
            TitleTextField.AnimateReadOnly = false;
            TitleTextField.BackgroundImageLayout = ImageLayout.None;
            TitleTextField.CharacterCasing = CharacterCasing.Normal;
            TitleTextField.Depth = 0;
            TitleTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TitleTextField.HideSelection = true;
            TitleTextField.Hint = "None";
            TitleTextField.LeadingIcon = null;
            TitleTextField.Location = new Point(12, 243);
            TitleTextField.MaxLength = 32767;
            TitleTextField.MouseState = MaterialSkin.MouseState.OUT;
            TitleTextField.Name = "TitleTextField";
            TitleTextField.PasswordChar = '\0';
            TitleTextField.PrefixSuffixText = null;
            TitleTextField.ReadOnly = false;
            TitleTextField.RightToLeft = RightToLeft.No;
            TitleTextField.SelectedText = "";
            TitleTextField.SelectionLength = 0;
            TitleTextField.SelectionStart = 0;
            TitleTextField.ShortcutsEnabled = true;
            TitleTextField.Size = new Size(131, 36);
            TitleTextField.TabIndex = 5;
            TitleTextField.TabStop = false;
            TitleTextField.TextAlign = HorizontalAlignment.Left;
            TitleTextField.TrailingIcon = null;
            TitleTextField.UseAccent = false;
            TitleTextField.UseSystemPasswordChar = false;
            TitleTextField.UseTallSize = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(57, 282);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(194, 282);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Artist";
            // 
            // ArtistTextField
            // 
            ArtistTextField.AnimateReadOnly = false;
            ArtistTextField.BackgroundImageLayout = ImageLayout.None;
            ArtistTextField.CharacterCasing = CharacterCasing.Normal;
            ArtistTextField.Depth = 0;
            ArtistTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ArtistTextField.HideSelection = true;
            ArtistTextField.Hint = "None";
            ArtistTextField.LeadingIcon = null;
            ArtistTextField.Location = new Point(150, 243);
            ArtistTextField.MaxLength = 32767;
            ArtistTextField.MouseState = MaterialSkin.MouseState.OUT;
            ArtistTextField.Name = "ArtistTextField";
            ArtistTextField.PasswordChar = '\0';
            ArtistTextField.PrefixSuffixText = null;
            ArtistTextField.ReadOnly = false;
            ArtistTextField.RightToLeft = RightToLeft.No;
            ArtistTextField.SelectedText = "";
            ArtistTextField.SelectionLength = 0;
            ArtistTextField.SelectionStart = 0;
            ArtistTextField.ShortcutsEnabled = true;
            ArtistTextField.Size = new Size(131, 36);
            ArtistTextField.TabIndex = 7;
            ArtistTextField.TabStop = false;
            ArtistTextField.TextAlign = HorizontalAlignment.Left;
            ArtistTextField.TrailingIcon = null;
            ArtistTextField.UseAccent = false;
            ArtistTextField.UseSystemPasswordChar = false;
            ArtistTextField.UseTallSize = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(54, 103);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 10;
            label3.Text = "BPM";
            // 
            // BPMTextField
            // 
            BPMTextField.AnimateReadOnly = false;
            BPMTextField.BackgroundImageLayout = ImageLayout.None;
            BPMTextField.CharacterCasing = CharacterCasing.Normal;
            BPMTextField.Depth = 0;
            BPMTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            BPMTextField.HideSelection = true;
            BPMTextField.Hint = "140";
            BPMTextField.LeadingIcon = null;
            BPMTextField.Location = new Point(43, 64);
            BPMTextField.MaxLength = 32767;
            BPMTextField.MouseState = MaterialSkin.MouseState.OUT;
            BPMTextField.Name = "BPMTextField";
            BPMTextField.PasswordChar = '\0';
            BPMTextField.PrefixSuffixText = null;
            BPMTextField.ReadOnly = false;
            BPMTextField.RightToLeft = RightToLeft.No;
            BPMTextField.SelectedText = "";
            BPMTextField.SelectionLength = 0;
            BPMTextField.SelectionStart = 0;
            BPMTextField.ShortcutsEnabled = true;
            BPMTextField.Size = new Size(57, 36);
            BPMTextField.TabIndex = 9;
            BPMTextField.TabStop = false;
            BPMTextField.TextAlign = HorizontalAlignment.Left;
            BPMTextField.TrailingIcon = null;
            BPMTextField.UseAccent = false;
            BPMTextField.UseSystemPasswordChar = false;
            BPMTextField.UseTallSize = false;
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Depth = 0;
            FileNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            FileNameLabel.Location = new Point(131, 156);
            FileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(115, 19);
            FileNameLabel.TabIndex = 11;
            FileNameLabel.Text = "waiting for file...";
            // 
            // PlusBpmLabelBut
            // 
            PlusBpmLabelBut.FlatStyle = FlatStyle.Flat;
            PlusBpmLabelBut.Location = new Point(106, 64);
            PlusBpmLabelBut.Name = "PlusBpmLabelBut";
            PlusBpmLabelBut.Size = new Size(25, 36);
            PlusBpmLabelBut.TabIndex = 12;
            PlusBpmLabelBut.Text = "+";
            PlusBpmLabelBut.UseVisualStyleBackColor = true;
            PlusBpmLabelBut.Click += PlusBpmLabelBut_Click_1;
            // 
            // MinusBpmLabelBut
            // 
            MinusBpmLabelBut.FlatStyle = FlatStyle.Flat;
            MinusBpmLabelBut.Location = new Point(12, 64);
            MinusBpmLabelBut.Name = "MinusBpmLabelBut";
            MinusBpmLabelBut.Size = new Size(25, 36);
            MinusBpmLabelBut.TabIndex = 13;
            MinusBpmLabelBut.Text = "-";
            MinusBpmLabelBut.UseVisualStyleBackColor = true;
            MinusBpmLabelBut.Click += MinusBpmLabelBut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(304, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 15;
            label4.Text = "Tuning fork";
            // 
            // TuningForkTextField
            // 
            TuningForkTextField.AnimateReadOnly = false;
            TuningForkTextField.BackgroundImageLayout = ImageLayout.None;
            TuningForkTextField.CharacterCasing = CharacterCasing.Normal;
            TuningForkTextField.Depth = 0;
            TuningForkTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TuningForkTextField.HideSelection = true;
            TuningForkTextField.Hint = "440";
            TuningForkTextField.LeadingIcon = null;
            TuningForkTextField.Location = new Point(275, 64);
            TuningForkTextField.MaxLength = 32767;
            TuningForkTextField.MouseState = MaterialSkin.MouseState.OUT;
            TuningForkTextField.Name = "TuningForkTextField";
            TuningForkTextField.PasswordChar = '\0';
            TuningForkTextField.PrefixSuffixText = null;
            TuningForkTextField.ReadOnly = false;
            TuningForkTextField.RightToLeft = RightToLeft.No;
            TuningForkTextField.SelectedText = "";
            TuningForkTextField.SelectionLength = 0;
            TuningForkTextField.SelectionStart = 0;
            TuningForkTextField.ShortcutsEnabled = true;
            TuningForkTextField.Size = new Size(120, 36);
            TuningForkTextField.TabIndex = 14;
            TuningForkTextField.TabStop = false;
            TuningForkTextField.TextAlign = HorizontalAlignment.Left;
            TuningForkTextField.TrailingIcon = null;
            TuningForkTextField.UseAccent = false;
            TuningForkTextField.UseSystemPasswordChar = false;
            TuningForkTextField.UseTallSize = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(194, 350);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 17;
            label5.Text = "Year";
            // 
            // YearTextField
            // 
            YearTextField.AnimateReadOnly = false;
            YearTextField.BackgroundImageLayout = ImageLayout.None;
            YearTextField.CharacterCasing = CharacterCasing.Normal;
            YearTextField.Depth = 0;
            YearTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            YearTextField.HideSelection = true;
            YearTextField.Hint = "2026";
            YearTextField.LeadingIcon = null;
            YearTextField.Location = new Point(150, 311);
            YearTextField.MaxLength = 32767;
            YearTextField.MouseState = MaterialSkin.MouseState.OUT;
            YearTextField.Name = "YearTextField";
            YearTextField.PasswordChar = '\0';
            YearTextField.PrefixSuffixText = null;
            YearTextField.ReadOnly = false;
            YearTextField.RightToLeft = RightToLeft.No;
            YearTextField.SelectedText = "";
            YearTextField.SelectionLength = 0;
            YearTextField.SelectionStart = 0;
            YearTextField.ShortcutsEnabled = true;
            YearTextField.Size = new Size(131, 36);
            YearTextField.TabIndex = 16;
            YearTextField.TabStop = false;
            YearTextField.Text = "2026";
            YearTextField.TextAlign = HorizontalAlignment.Left;
            YearTextField.TrailingIcon = null;
            YearTextField.UseAccent = false;
            YearTextField.UseSystemPasswordChar = false;
            YearTextField.UseTallSize = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(182, 103);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 19;
            label6.Text = "Key";
            // 
            // KeyTextField
            // 
            KeyTextField.AnimateReadOnly = false;
            KeyTextField.BackgroundImageLayout = ImageLayout.None;
            KeyTextField.CharacterCasing = CharacterCasing.Normal;
            KeyTextField.Depth = 0;
            KeyTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            KeyTextField.HideSelection = true;
            KeyTextField.Hint = "Am";
            KeyTextField.LeadingIcon = null;
            KeyTextField.Location = new Point(138, 64);
            KeyTextField.MaxLength = 32767;
            KeyTextField.MouseState = MaterialSkin.MouseState.OUT;
            KeyTextField.Name = "KeyTextField";
            KeyTextField.PasswordChar = '\0';
            KeyTextField.PrefixSuffixText = null;
            KeyTextField.ReadOnly = false;
            KeyTextField.RightToLeft = RightToLeft.No;
            KeyTextField.SelectedText = "";
            KeyTextField.SelectionLength = 0;
            KeyTextField.SelectionStart = 0;
            KeyTextField.ShortcutsEnabled = true;
            KeyTextField.Size = new Size(125, 36);
            KeyTextField.TabIndex = 18;
            KeyTextField.TabStop = false;
            KeyTextField.TextAlign = HorizontalAlignment.Left;
            KeyTextField.TrailingIcon = null;
            KeyTextField.UseAccent = false;
            KeyTextField.UseSystemPasswordChar = false;
            KeyTextField.UseTallSize = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(330, 282);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 21;
            label7.Text = "Album";
            // 
            // AlbumTextField
            // 
            AlbumTextField.AnimateReadOnly = false;
            AlbumTextField.BackgroundImageLayout = ImageLayout.None;
            AlbumTextField.CharacterCasing = CharacterCasing.Normal;
            AlbumTextField.Depth = 0;
            AlbumTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            AlbumTextField.HideSelection = true;
            AlbumTextField.Hint = "None";
            AlbumTextField.LeadingIcon = null;
            AlbumTextField.Location = new Point(287, 243);
            AlbumTextField.MaxLength = 32767;
            AlbumTextField.MouseState = MaterialSkin.MouseState.OUT;
            AlbumTextField.Name = "AlbumTextField";
            AlbumTextField.PasswordChar = '\0';
            AlbumTextField.PrefixSuffixText = null;
            AlbumTextField.ReadOnly = false;
            AlbumTextField.RightToLeft = RightToLeft.No;
            AlbumTextField.SelectedText = "";
            AlbumTextField.SelectionLength = 0;
            AlbumTextField.SelectionStart = 0;
            AlbumTextField.ShortcutsEnabled = true;
            AlbumTextField.Size = new Size(131, 36);
            AlbumTextField.TabIndex = 20;
            AlbumTextField.TabStop = false;
            AlbumTextField.TextAlign = HorizontalAlignment.Left;
            AlbumTextField.TrailingIcon = null;
            AlbumTextField.UseAccent = false;
            AlbumTextField.UseSystemPasswordChar = false;
            AlbumTextField.UseTallSize = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(55, 350);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 23;
            label8.Text = "Genre";
            // 
            // GenreTextField
            // 
            GenreTextField.AnimateReadOnly = false;
            GenreTextField.BackgroundImageLayout = ImageLayout.None;
            GenreTextField.CharacterCasing = CharacterCasing.Normal;
            GenreTextField.Depth = 0;
            GenreTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            GenreTextField.HideSelection = true;
            GenreTextField.Hint = "None";
            GenreTextField.LeadingIcon = null;
            GenreTextField.Location = new Point(12, 311);
            GenreTextField.MaxLength = 32767;
            GenreTextField.MouseState = MaterialSkin.MouseState.OUT;
            GenreTextField.Name = "GenreTextField";
            GenreTextField.PasswordChar = '\0';
            GenreTextField.PrefixSuffixText = null;
            GenreTextField.ReadOnly = false;
            GenreTextField.RightToLeft = RightToLeft.No;
            GenreTextField.SelectedText = "";
            GenreTextField.SelectionLength = 0;
            GenreTextField.SelectionStart = 0;
            GenreTextField.ShortcutsEnabled = true;
            GenreTextField.Size = new Size(131, 36);
            GenreTextField.TabIndex = 22;
            GenreTextField.TabStop = false;
            GenreTextField.TextAlign = HorizontalAlignment.Left;
            GenreTextField.TrailingIcon = null;
            GenreTextField.UseAccent = false;
            GenreTextField.UseSystemPasswordChar = false;
            GenreTextField.UseTallSize = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Carlito", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(316, 350);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 25;
            label9.Text = "Track Count";
            // 
            // TrackNumTextField
            // 
            TrackNumTextField.AnimateReadOnly = false;
            TrackNumTextField.BackgroundImageLayout = ImageLayout.None;
            TrackNumTextField.CharacterCasing = CharacterCasing.Normal;
            TrackNumTextField.Depth = 0;
            TrackNumTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TrackNumTextField.HideSelection = true;
            TrackNumTextField.Hint = "0";
            TrackNumTextField.LeadingIcon = null;
            TrackNumTextField.Location = new Point(288, 311);
            TrackNumTextField.MaxLength = 32767;
            TrackNumTextField.MouseState = MaterialSkin.MouseState.OUT;
            TrackNumTextField.Name = "TrackNumTextField";
            TrackNumTextField.PasswordChar = '\0';
            TrackNumTextField.PrefixSuffixText = null;
            TrackNumTextField.ReadOnly = false;
            TrackNumTextField.RightToLeft = RightToLeft.No;
            TrackNumTextField.SelectedText = "";
            TrackNumTextField.SelectionLength = 0;
            TrackNumTextField.SelectionStart = 0;
            TrackNumTextField.ShortcutsEnabled = true;
            TrackNumTextField.Size = new Size(131, 36);
            TrackNumTextField.TabIndex = 24;
            TrackNumTextField.TabStop = false;
            TrackNumTextField.TextAlign = HorizontalAlignment.Left;
            TrackNumTextField.TrailingIcon = null;
            TrackNumTextField.UseAccent = false;
            TrackNumTextField.UseSystemPasswordChar = false;
            TrackNumTextField.UseTallSize = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CommentTextField);
            groupBox1.Controls.Add(KeyTextField);
            groupBox1.Controls.Add(BPMTextField);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PlusBpmLabelBut);
            groupBox1.Controls.Add(MinusBpmLabelBut);
            groupBox1.Controls.Add(TuningForkTextField);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 368);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 130);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comment (can be left blank)";
            // 
            // CommentTextField
            // 
            CommentTextField.AnimateReadOnly = false;
            CommentTextField.BackgroundImageLayout = ImageLayout.None;
            CommentTextField.CharacterCasing = CharacterCasing.Normal;
            CommentTextField.Depth = 0;
            CommentTextField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CommentTextField.HideSelection = true;
            CommentTextField.Hint = "Your comment on this file";
            CommentTextField.LeadingIcon = null;
            CommentTextField.Location = new Point(12, 22);
            CommentTextField.MaxLength = 32767;
            CommentTextField.MouseState = MaterialSkin.MouseState.OUT;
            CommentTextField.Name = "CommentTextField";
            CommentTextField.PasswordChar = '\0';
            CommentTextField.PrefixSuffixText = null;
            CommentTextField.ReadOnly = false;
            CommentTextField.RightToLeft = RightToLeft.No;
            CommentTextField.SelectedText = "";
            CommentTextField.SelectionLength = 0;
            CommentTextField.SelectionStart = 0;
            CommentTextField.ShortcutsEnabled = true;
            CommentTextField.Size = new Size(384, 36);
            CommentTextField.TabIndex = 29;
            CommentTextField.TabStop = false;
            CommentTextField.TextAlign = HorizontalAlignment.Left;
            CommentTextField.TrailingIcon = null;
            CommentTextField.UseAccent = false;
            CommentTextField.UseSystemPasswordChar = false;
            CommentTextField.UseTallSize = false;
            // 
            // SaveLabel
            // 
            SaveLabel.AutoSize = true;
            SaveLabel.ForeColor = Color.Red;
            SaveLabel.Location = new Point(131, 175);
            SaveLabel.Name = "SaveLabel";
            SaveLabel.Size = new Size(52, 14);
            SaveLabel.TabIndex = 27;
            SaveLabel.Text = "Unsaved";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(141, 94);
            label10.Name = "label10";
            label10.Size = new Size(140, 14);
            label10.TabIndex = 28;
            label10.Text = "mp3 jpg jpeg png bmp gif";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 572);
            Controls.Add(label10);
            Controls.Add(SaveLabel);
            Controls.Add(groupBox1);
            Controls.Add(SaveBut);
            Controls.Add(label9);
            Controls.Add(TrackNumTextField);
            Controls.Add(label8);
            Controls.Add(GenreTextField);
            Controls.Add(label7);
            Controls.Add(AlbumTextField);
            Controls.Add(label5);
            Controls.Add(YearTextField);
            Controls.Add(FileNameLabel);
            Controls.Add(label2);
            Controls.Add(ArtistTextField);
            Controls.Add(label1);
            Controls.Add(TitleTextField);
            Controls.Add(ImagePreviewPanel);
            Controls.Add(DropPanel);
            Controls.Add(materialDrawer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MP3 MetaTag";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SaveBut;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Panel DropPanel;
        private Panel ImagePreviewPanel;
        private MaterialSkin.Controls.MaterialTextBox2 TitleTextField;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 ArtistTextField;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 BPMTextField;
        private MaterialSkin.Controls.MaterialLabel FileNameLabel;
        private Button PlusBpmLabelBut;
        private Button MinusBpmLabelBut;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox2 TuningForkTextField;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox2 YearTextField;
        private Label label6;
        private MaterialSkin.Controls.MaterialTextBox2 KeyTextField;
        private Label label7;
        private MaterialSkin.Controls.MaterialTextBox2 AlbumTextField;
        private Label label8;
        private MaterialSkin.Controls.MaterialTextBox2 GenreTextField;
        private Label label9;
        private MaterialSkin.Controls.MaterialTextBox2 TrackNumTextField;
        private GroupBox groupBox1;
        private Label SaveLabel;
        private Label label10;
        private MaterialSkin.Controls.MaterialTextBox2 CommentTextField;
    }
}
