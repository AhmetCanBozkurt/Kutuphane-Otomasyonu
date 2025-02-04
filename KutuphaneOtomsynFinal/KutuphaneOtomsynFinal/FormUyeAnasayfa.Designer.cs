
namespace KutuphaneOtomsynFinal
{
    partial class FormUyeAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeAnasayfa));
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.timerKapaMenu = new System.Windows.Forms.Timer(this.components);
            this.timerAcMenu = new System.Windows.Forms.Timer(this.components);
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mailLabel = new System.Windows.Forms.TextBox();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cikisYap = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.selectedBar = new System.Windows.Forms.Panel();
            this.btnEmanetIslem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUyeIslem = new System.Windows.Forms.Button();
            this.btnKitapIslem = new System.Windows.Forms.Button();
            this.logoBtn = new System.Windows.Forms.PictureBox();
            this.mobileMenuSlider = new System.Windows.Forms.PictureBox();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileMenuSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // timerKapaMenu
            // 
            this.timerKapaMenu.Interval = 40;
            this.timerKapaMenu.Tick += new System.EventHandler(this.timerKapaMenu_Tick);
            // 
            // timerAcMenu
            // 
            this.timerAcMenu.Tick += new System.EventHandler(this.timerAcMenu_Tick);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(145)))), ((int)(((byte)(84)))));
            this.PanelTop.Controls.Add(this.btnMax);
            this.PanelTop.Controls.Add(this.btnNormal);
            this.PanelTop.Controls.Add(this.btnMin);
            this.PanelTop.Controls.Add(this.btnExit);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1482, 49);
            this.PanelTop.TabIndex = 7;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1380, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(53, 49);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(1380, 0);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(53, 49);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1331, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(53, 49);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1428, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.selectedBar);
            this.PanelMenu.Controls.Add(this.btnEmanetIslem);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.btnUyeIslem);
            this.PanelMenu.Controls.Add(this.btnKitapIslem);
            this.PanelMenu.Controls.Add(this.logoBtn);
            this.PanelMenu.Controls.Add(this.mobileMenuSlider);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 49);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(293, 847);
            this.PanelMenu.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mailLabel);
            this.panel2.Controls.Add(this.adSoyad);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 648);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 87);
            this.panel2.TabIndex = 14;
            // 
            // mailLabel
            // 
            this.mailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.mailLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.mailLabel.Location = new System.Drawing.Point(96, 4);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(4);
            this.mailLabel.Multiline = true;
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(197, 25);
            this.mailLabel.TabIndex = 12;
            this.mailLabel.Text = "mail";
            this.mailLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adSoyad
            // 
            this.adSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.adSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adSoyad.ForeColor = System.Drawing.Color.SkyBlue;
            this.adSoyad.Location = new System.Drawing.Point(92, 37);
            this.adSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adSoyad.Multiline = true;
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(197, 25);
            this.adSoyad.TabIndex = 0;
            this.adSoyad.Text = "sifre";
            this.adSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cikisYap);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 735);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 43);
            this.panel3.TabIndex = 1;
            // 
            // cikisYap
            // 
            this.cikisYap.AutoSize = true;
            this.cikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.ForeColor = System.Drawing.Color.SkyBlue;
            this.cikisYap.Location = new System.Drawing.Point(143, 11);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(79, 20);
            this.cikisYap.TabIndex = 11;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTarih);
            this.panel1.Controls.Add(this.labelSaat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 778);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 69);
            this.panel1.TabIndex = 9;
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelTarih.Location = new System.Drawing.Point(101, 44);
            this.labelTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(41, 17);
            this.labelTarih.TabIndex = 11;
            this.labelTarih.Text = "Tarih";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelSaat.Location = new System.Drawing.Point(109, 18);
            this.labelSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(37, 17);
            this.labelSaat.TabIndex = 10;
            this.labelSaat.Text = "Saat";
            // 
            // selectedBar
            // 
            this.selectedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(145)))), ((int)(((byte)(84)))));
            this.selectedBar.Location = new System.Drawing.Point(4, 215);
            this.selectedBar.Margin = new System.Windows.Forms.Padding(4);
            this.selectedBar.Name = "selectedBar";
            this.selectedBar.Size = new System.Drawing.Size(7, 74);
            this.selectedBar.TabIndex = 0;
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetIslem.FlatAppearance.BorderSize = 0;
            this.btnEmanetIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(145)))), ((int)(((byte)(84)))));
            this.btnEmanetIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetIslem.ForeColor = System.Drawing.Color.White;
            this.btnEmanetIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslem.Image")));
            this.btnEmanetIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetIslem.Location = new System.Drawing.Point(0, 412);
            this.btnEmanetIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmanetIslem.Size = new System.Drawing.Size(293, 74);
            this.btnEmanetIslem.TabIndex = 6;
            this.btnEmanetIslem.Text = "              Profil İşlemleri";
            this.btnEmanetIslem.UseVisualStyleBackColor = true;
            this.btnEmanetIslem.Click += new System.EventHandler(this.btnEmanetIslem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "KÜTÜPHANESİ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "PULİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUyeIslem
            // 
            this.btnUyeIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeIslem.FlatAppearance.BorderSize = 0;
            this.btnUyeIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(145)))), ((int)(((byte)(84)))));
            this.btnUyeIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeIslem.ForeColor = System.Drawing.Color.White;
            this.btnUyeIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeIslem.Image")));
            this.btnUyeIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeIslem.Location = new System.Drawing.Point(0, 314);
            this.btnUyeIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeIslem.Name = "btnUyeIslem";
            this.btnUyeIslem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUyeIslem.Size = new System.Drawing.Size(293, 74);
            this.btnUyeIslem.TabIndex = 3;
            this.btnUyeIslem.Text = "               İade Ettiklerim";
            this.btnUyeIslem.UseVisualStyleBackColor = true;
            this.btnUyeIslem.Click += new System.EventHandler(this.btnUyeIslem_Click);
            // 
            // btnKitapIslem
            // 
            this.btnKitapIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapIslem.FlatAppearance.BorderSize = 0;
            this.btnKitapIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(145)))), ((int)(((byte)(84)))));
            this.btnKitapIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapIslem.ForeColor = System.Drawing.Color.White;
            this.btnKitapIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapIslem.Image")));
            this.btnKitapIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapIslem.Location = new System.Drawing.Point(0, 215);
            this.btnKitapIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapIslem.Name = "btnKitapIslem";
            this.btnKitapIslem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKitapIslem.Size = new System.Drawing.Size(293, 74);
            this.btnKitapIslem.TabIndex = 2;
            this.btnKitapIslem.Text = "              Üzerimdekiler";
            this.btnKitapIslem.UseVisualStyleBackColor = true;
            this.btnKitapIslem.Click += new System.EventHandler(this.btnKitapIslem_Click);
            // 
            // logoBtn
            // 
            this.logoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(0, 80);
            this.logoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.logoBtn.Size = new System.Drawing.Size(293, 123);
            this.logoBtn.TabIndex = 1;
            this.logoBtn.TabStop = false;
            this.logoBtn.Click += new System.EventHandler(this.logoBtn_Click);
            // 
            // mobileMenuSlider
            // 
            this.mobileMenuSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobileMenuSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mobileMenuSlider.Image = ((System.Drawing.Image)(resources.GetObject("mobileMenuSlider.Image")));
            this.mobileMenuSlider.Location = new System.Drawing.Point(203, 0);
            this.mobileMenuSlider.Margin = new System.Windows.Forms.Padding(4);
            this.mobileMenuSlider.Name = "mobileMenuSlider";
            this.mobileMenuSlider.Size = new System.Drawing.Size(68, 61);
            this.mobileMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mobileMenuSlider.TabIndex = 0;
            this.mobileMenuSlider.TabStop = false;
            this.mobileMenuSlider.Click += new System.EventHandler(this.mobileMenuSlider_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(293, 49);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(4);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1189, 847);
            this.PanelContent.TabIndex = 10;
            // 
            // FormUyeAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 896);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUyeAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUyeAnasayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUyeAnasayfa_FormClosed);
            this.Load += new System.EventHandler(this.FormUyeAnasayfa_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileMenuSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Timer timerKapaMenu;
        private System.Windows.Forms.Timer timerAcMenu;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mailLabel;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cikisYap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Panel selectedBar;
        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUyeIslem;
        private System.Windows.Forms.Button btnKitapIslem;
        private System.Windows.Forms.PictureBox logoBtn;
        private System.Windows.Forms.PictureBox mobileMenuSlider;
        private System.Windows.Forms.Panel PanelContent;
    }
}