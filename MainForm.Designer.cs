partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroControlBox1 = new MetroSuite.MetroControlBox();
            this.firefoxMainTabControl1 = new FirefoxMainTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroButton8 = new MetroSuite.MetroButton();
            this.metroButton5 = new MetroSuite.MetroButton();
            this.metroButton2 = new MetroSuite.MetroButton();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.metroTextbox1 = new MetroSuite.MetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroButton7 = new MetroSuite.MetroButton();
            this.metroButton6 = new MetroSuite.MetroButton();
            this.metroButton3 = new MetroSuite.MetroButton();
            this.metroButton4 = new MetroSuite.MetroButton();
            this.metroTextbox2 = new MetroSuite.MetroTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.firefoxMainTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Png image file (*.png)|*.png";
            this.saveFileDialog1.Title = "Save your encoded image...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Png image file (*.png)|*.png";
            this.openFileDialog1.Title = "Open your encoded image...";
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroControlBox1.Location = new System.Drawing.Point(660, 1);
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(96, 32);
            this.metroControlBox1.TabIndex = 0;
            // 
            // firefoxMainTabControl1
            // 
            this.firefoxMainTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.firefoxMainTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firefoxMainTabControl1.Controls.Add(this.tabPage1);
            this.firefoxMainTabControl1.Controls.Add(this.tabPage2);
            this.firefoxMainTabControl1.ImageList = this.imageList1;
            this.firefoxMainTabControl1.ItemSize = new System.Drawing.Size(43, 160);
            this.firefoxMainTabControl1.Location = new System.Drawing.Point(1, 35);
            this.firefoxMainTabControl1.Multiline = true;
            this.firefoxMainTabControl1.Name = "firefoxMainTabControl1";
            this.firefoxMainTabControl1.SelectedIndex = 0;
            this.firefoxMainTabControl1.Size = new System.Drawing.Size(755, 364);
            this.firefoxMainTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.firefoxMainTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.metroButton8);
            this.tabPage1.Controls.Add(this.metroButton5);
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.metroTextbox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(164, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Encoder";
            // 
            // metroButton8
            // 
            this.metroButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton8.BackColor = System.Drawing.Color.Transparent;
            this.metroButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton8.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton8.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton8.Location = new System.Drawing.Point(16, 313);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton8.RoundingArc = 23;
            this.metroButton8.Size = new System.Drawing.Size(256, 30);
            this.metroButton8.Style = MetroSuite.Design.Style.Dark;
            this.metroButton8.TabIndex = 5;
            this.metroButton8.Text = "Set text to encode by Clipboard";
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton5.BackColor = System.Drawing.Color.Transparent;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton5.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton5.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton5.Location = new System.Drawing.Point(278, 313);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton5.RoundingArc = 23;
            this.metroButton5.Size = new System.Drawing.Size(302, 30);
            this.metroButton5.Style = MetroSuite.Design.Style.Dark;
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "Copy encoded image to your Clipboard";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton2.Location = new System.Drawing.Point(16, 277);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton2.RoundingArc = 23;
            this.metroButton2.Size = new System.Drawing.Size(256, 30);
            this.metroButton2.Style = MetroSuite.Design.Style.Dark;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Save encoded image";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton1.Location = new System.Drawing.Point(278, 277);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton1.RoundingArc = 23;
            this.metroButton1.Size = new System.Drawing.Size(302, 30);
            this.metroButton1.Style = MetroSuite.Design.Style.Dark;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Encode your text onto an image";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextbox1
            // 
            this.metroTextbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroTextbox1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroTextbox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroTextbox1.HideSelection = false;
            this.metroTextbox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroTextbox1.Location = new System.Drawing.Point(278, 15);
            this.metroTextbox1.MaxLength = 8180;
            this.metroTextbox1.Multiline = true;
            this.metroTextbox1.Name = "metroTextbox1";
            this.metroTextbox1.PasswordChar = '\0';
            this.metroTextbox1.Size = new System.Drawing.Size(302, 256);
            this.metroTextbox1.Style = MetroSuite.Design.Style.Dark;
            this.metroTextbox1.TabIndex = 1;
            this.metroTextbox1.Text = "Insert the text to encode here...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.metroButton7);
            this.tabPage2.Controls.Add(this.metroButton6);
            this.tabPage2.Controls.Add(this.metroButton3);
            this.tabPage2.Controls.Add(this.metroButton4);
            this.tabPage2.Controls.Add(this.metroTextbox2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(164, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image Decoder";
            // 
            // metroButton7
            // 
            this.metroButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton7.BackColor = System.Drawing.Color.Transparent;
            this.metroButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton7.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton7.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton7.Location = new System.Drawing.Point(16, 313);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton7.RoundingArc = 23;
            this.metroButton7.Size = new System.Drawing.Size(256, 30);
            this.metroButton7.Style = MetroSuite.Design.Style.Dark;
            this.metroButton7.TabIndex = 9;
            this.metroButton7.Text = "Open your image by Clipboard";
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton6.BackColor = System.Drawing.Color.Transparent;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton6.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton6.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton6.Location = new System.Drawing.Point(278, 313);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton6.RoundingArc = 23;
            this.metroButton6.Size = new System.Drawing.Size(302, 30);
            this.metroButton6.Style = MetroSuite.Design.Style.Dark;
            this.metroButton6.TabIndex = 8;
            this.metroButton6.Text = "Copy decoded text to your Clipboard";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton3.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton3.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton3.Location = new System.Drawing.Point(16, 277);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton3.RoundingArc = 23;
            this.metroButton3.Size = new System.Drawing.Size(256, 30);
            this.metroButton3.Style = MetroSuite.Design.Style.Dark;
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Open your encoded image";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton4.BackColor = System.Drawing.Color.Transparent;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton4.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton4.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroButton4.Location = new System.Drawing.Point(278, 277);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton4.RoundingArc = 23;
            this.metroButton4.Size = new System.Drawing.Size(302, 30);
            this.metroButton4.Style = MetroSuite.Design.Style.Dark;
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Decode the encoded image to text";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroTextbox2
            // 
            this.metroTextbox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTextbox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroTextbox2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroTextbox2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.metroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroTextbox2.HideSelection = false;
            this.metroTextbox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroTextbox2.Location = new System.Drawing.Point(278, 15);
            this.metroTextbox2.MaxLength = 8180;
            this.metroTextbox2.Multiline = true;
            this.metroTextbox2.Name = "metroTextbox2";
            this.metroTextbox2.PasswordChar = '\0';
            this.metroTextbox2.ReadOnly = true;
            this.metroTextbox2.Size = new System.Drawing.Size(302, 256);
            this.metroTextbox2.Style = MetroSuite.Design.Style.Dark;
            this.metroTextbox2.TabIndex = 5;
            this.metroTextbox2.Text = "The decoded text will appear here.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "picture.png");
            // 
            // MainForm
            // 
            this.AccentColor = System.Drawing.Color.Gold;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(757, 401);
            this.Controls.Add(this.firefoxMainTabControl1);
            this.Controls.Add(this.metroControlBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainControlBox = this.metroControlBox1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "WBCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.firefoxMainTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

    }
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private MetroSuite.MetroControlBox metroControlBox1;
    private FirefoxMainTabControl firefoxMainTabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private MetroSuite.MetroTextbox metroTextbox1;
    private MetroSuite.MetroButton metroButton1;
    private MetroSuite.MetroButton metroButton2;
    private MetroSuite.MetroButton metroButton3;
    private MetroSuite.MetroButton metroButton4;
    private MetroSuite.MetroTextbox metroTextbox2;
    private System.Windows.Forms.PictureBox pictureBox2;
    private MetroSuite.MetroButton metroButton5;
    private MetroSuite.MetroButton metroButton6;
    private MetroSuite.MetroButton metroButton7;
    private MetroSuite.MetroButton metroButton8;
}