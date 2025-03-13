namespace Kütüphane_Otomasyon_Sistemi
{
    partial class AnaMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenuForm));
            this.btn_Kitaplar = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Uyeler = new System.Windows.Forms.Button();
            this.btn_Sorumlular = new System.Windows.Forms.Button();
            this.btn_Yazarlar = new System.Windows.Forms.Button();
            this.btn_Yayinevi = new System.Windows.Forms.Button();
            this.btn_Turler = new System.Windows.Forms.Button();
            this.btn_OduncVerme = new System.Windows.Forms.Button();
            this.btn_Rezervasyon = new System.Windows.Forms.Button();
            this.btn_KategoriRaflar = new System.Windows.Forms.Button();
            this.btn_Raporlar = new System.Windows.Forms.Button();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.lbl_Hosgeldiniz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kitaplar
            // 
            this.btn_Kitaplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Kitaplar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kitaplar.ImageKey = "depositphotos_270747206-stock-illustration-stack-books-cartoon-illustration-stack" +
    ".jpg";
            this.btn_Kitaplar.ImageList = this.ımageList1;
            this.btn_Kitaplar.Location = new System.Drawing.Point(215, 118);
            this.btn_Kitaplar.Name = "btn_Kitaplar";
            this.btn_Kitaplar.Size = new System.Drawing.Size(214, 141);
            this.btn_Kitaplar.TabIndex = 0;
            this.btn_Kitaplar.Text = "KİTAPLAR";
            this.btn_Kitaplar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Kitaplar.UseVisualStyleBackColor = false;
            this.btn_Kitaplar.Click += new System.EventHandler(this.btn_KitapKayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "boy-with-glasses-lends-a-book-to-his-friend-vector.jpg");
            this.ımageList1.Images.SetKeyName(1, "depositphotos_270747206-stock-illustration-stack-books-cartoon-illustration-stack" +
        ".jpg");
            this.ımageList1.Images.SetKeyName(2, "download.png");
            this.ımageList1.Images.SetKeyName(3, "duvar-resimleri-kutuphane-kitap-raf-arka-plan-vektor.jpg.jpg");
            this.ımageList1.Images.SetKeyName(4, "images.png");
            this.ımageList1.Images.SetKeyName(5, "istockphoto-454054639-612x612.jpg");
            this.ımageList1.Images.SetKeyName(6, "istockphoto-1296390218-612x612.jpg");
            this.ımageList1.Images.SetKeyName(7, "pngtree-statistics-graph-bar-png-image_14618881.png");
            this.ımageList1.Images.SetKeyName(8, "ulusal-ve-uluslarası-yayınevi-nedir.jpg");
            this.ımageList1.Images.SetKeyName(9, "uye.png");
            this.ımageList1.Images.SetKeyName(10, "yayinevi.png");
            this.ımageList1.Images.SetKeyName(11, "Çıkış.png");
            this.ımageList1.Images.SetKeyName(12, "pngtree-checklist-comic-icon-for-reports-and-business-check-evaluation-analysis-v" +
        "ector-png-image_12861732.png");
            this.ımageList1.Images.SetKeyName(13, "settings-icon_2691259.jpg");
            // 
            // btn_Uyeler
            // 
            this.btn_Uyeler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Uyeler.BackColor = System.Drawing.Color.Transparent;
            this.btn_Uyeler.ImageKey = "uye.png";
            this.btn_Uyeler.ImageList = this.ımageList1;
            this.btn_Uyeler.Location = new System.Drawing.Point(484, 118);
            this.btn_Uyeler.Name = "btn_Uyeler";
            this.btn_Uyeler.Size = new System.Drawing.Size(214, 141);
            this.btn_Uyeler.TabIndex = 1;
            this.btn_Uyeler.Text = "ÜYELER";
            this.btn_Uyeler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Uyeler.UseVisualStyleBackColor = false;
            this.btn_Uyeler.Click += new System.EventHandler(this.btn_KisiKayit_Click);
            // 
            // btn_Sorumlular
            // 
            this.btn_Sorumlular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sorumlular.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sorumlular.ImageKey = "images.png";
            this.btn_Sorumlular.ImageList = this.ımageList1;
            this.btn_Sorumlular.Location = new System.Drawing.Point(756, 118);
            this.btn_Sorumlular.Name = "btn_Sorumlular";
            this.btn_Sorumlular.Size = new System.Drawing.Size(214, 141);
            this.btn_Sorumlular.TabIndex = 2;
            this.btn_Sorumlular.Text = "SORUMLULAR";
            this.btn_Sorumlular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sorumlular.UseVisualStyleBackColor = false;
            this.btn_Sorumlular.Click += new System.EventHandler(this.btn_SorumluKayit_Click);
            // 
            // btn_Yazarlar
            // 
            this.btn_Yazarlar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Yazarlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Yazarlar.ImageKey = "download.png";
            this.btn_Yazarlar.ImageList = this.ımageList1;
            this.btn_Yazarlar.Location = new System.Drawing.Point(1025, 118);
            this.btn_Yazarlar.Name = "btn_Yazarlar";
            this.btn_Yazarlar.Size = new System.Drawing.Size(214, 141);
            this.btn_Yazarlar.TabIndex = 3;
            this.btn_Yazarlar.Text = "YAZARLAR";
            this.btn_Yazarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Yazarlar.UseVisualStyleBackColor = false;
            this.btn_Yazarlar.Click += new System.EventHandler(this.btn_YazarKayit_Click);
            // 
            // btn_Yayinevi
            // 
            this.btn_Yayinevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Yayinevi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Yayinevi.ImageKey = "ulusal-ve-uluslarası-yayınevi-nedir.jpg";
            this.btn_Yayinevi.ImageList = this.ımageList1;
            this.btn_Yayinevi.Location = new System.Drawing.Point(215, 355);
            this.btn_Yayinevi.Name = "btn_Yayinevi";
            this.btn_Yayinevi.Size = new System.Drawing.Size(214, 141);
            this.btn_Yayinevi.TabIndex = 4;
            this.btn_Yayinevi.Text = "YAYINEVİ";
            this.btn_Yayinevi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Yayinevi.UseVisualStyleBackColor = false;
            this.btn_Yayinevi.Click += new System.EventHandler(this.btn_YayineviKayit_Click);
            // 
            // btn_Turler
            // 
            this.btn_Turler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Turler.BackColor = System.Drawing.Color.Transparent;
            this.btn_Turler.ImageKey = "yayinevi.png";
            this.btn_Turler.ImageList = this.ımageList1;
            this.btn_Turler.Location = new System.Drawing.Point(484, 355);
            this.btn_Turler.Name = "btn_Turler";
            this.btn_Turler.Size = new System.Drawing.Size(214, 141);
            this.btn_Turler.TabIndex = 5;
            this.btn_Turler.Text = "TÜRLER";
            this.btn_Turler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Turler.UseVisualStyleBackColor = false;
            this.btn_Turler.Click += new System.EventHandler(this.btn_TurlerKayit_Click);
            // 
            // btn_OduncVerme
            // 
            this.btn_OduncVerme.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OduncVerme.BackColor = System.Drawing.Color.Transparent;
            this.btn_OduncVerme.ImageKey = "boy-with-glasses-lends-a-book-to-his-friend-vector.jpg";
            this.btn_OduncVerme.ImageList = this.ımageList1;
            this.btn_OduncVerme.Location = new System.Drawing.Point(1025, 355);
            this.btn_OduncVerme.Name = "btn_OduncVerme";
            this.btn_OduncVerme.Size = new System.Drawing.Size(214, 141);
            this.btn_OduncVerme.TabIndex = 6;
            this.btn_OduncVerme.Text = "ÖDÜNÇ";
            this.btn_OduncVerme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_OduncVerme.UseVisualStyleBackColor = false;
            this.btn_OduncVerme.Click += new System.EventHandler(this.btn_OduncVerme_Click);
            // 
            // btn_Rezervasyon
            // 
            this.btn_Rezervasyon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Rezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyon.ImageKey = "istockphoto-1296390218-612x612.jpg";
            this.btn_Rezervasyon.ImageList = this.ımageList1;
            this.btn_Rezervasyon.Location = new System.Drawing.Point(215, 582);
            this.btn_Rezervasyon.Name = "btn_Rezervasyon";
            this.btn_Rezervasyon.Size = new System.Drawing.Size(214, 141);
            this.btn_Rezervasyon.TabIndex = 8;
            this.btn_Rezervasyon.Text = "REZERVASYON";
            this.btn_Rezervasyon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Rezervasyon.UseVisualStyleBackColor = false;
            this.btn_Rezervasyon.Click += new System.EventHandler(this.btn_Rezervasyon_Click);
            // 
            // btn_KategoriRaflar
            // 
            this.btn_KategoriRaflar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_KategoriRaflar.BackColor = System.Drawing.Color.Transparent;
            this.btn_KategoriRaflar.ImageKey = "duvar-resimleri-kutuphane-kitap-raf-arka-plan-vektor.jpg.jpg";
            this.btn_KategoriRaflar.ImageList = this.ımageList1;
            this.btn_KategoriRaflar.Location = new System.Drawing.Point(756, 355);
            this.btn_KategoriRaflar.Name = "btn_KategoriRaflar";
            this.btn_KategoriRaflar.Size = new System.Drawing.Size(214, 141);
            this.btn_KategoriRaflar.TabIndex = 9;
            this.btn_KategoriRaflar.Text = "KATEGORİ / RAFLAR";
            this.btn_KategoriRaflar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_KategoriRaflar.UseVisualStyleBackColor = false;
            this.btn_KategoriRaflar.Click += new System.EventHandler(this.btn_KategoriRaflar_Click);
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Raporlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Raporlar.ImageKey = "pngtree-checklist-comic-icon-for-reports-and-business-check-evaluation-analysis-v" +
    "ector-png-image_12861732.png";
            this.btn_Raporlar.ImageList = this.ımageList1;
            this.btn_Raporlar.Location = new System.Drawing.Point(489, 582);
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.Size = new System.Drawing.Size(214, 141);
            this.btn_Raporlar.TabIndex = 10;
            this.btn_Raporlar.Text = "RAPORLAR";
            this.btn_Raporlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Raporlar.UseVisualStyleBackColor = false;
            this.btn_Raporlar.Click += new System.EventHandler(this.btn_Raporlar_Click);
            // 
            // btn_Ayarlar
            // 
            this.btn_Ayarlar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ayarlar.ImageKey = "settings-icon_2691259.jpg";
            this.btn_Ayarlar.ImageList = this.ımageList1;
            this.btn_Ayarlar.Location = new System.Drawing.Point(756, 582);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(214, 141);
            this.btn_Ayarlar.TabIndex = 11;
            this.btn_Ayarlar.Text = "AYARLAR";
            this.btn_Ayarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ayarlar.UseVisualStyleBackColor = false;
            this.btn_Ayarlar.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // lbl_Hosgeldiniz
            // 
            this.lbl_Hosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Hosgeldiniz.Location = new System.Drawing.Point(516, 42);
            this.lbl_Hosgeldiniz.Name = "lbl_Hosgeldiniz";
            this.lbl_Hosgeldiniz.Size = new System.Drawing.Size(486, 30);
            this.lbl_Hosgeldiniz.TabIndex = 12;
            this.lbl_Hosgeldiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ImageKey = "Çıkış.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1025, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 141);
            this.button1.TabIndex = 13;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1497, 881);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Hosgeldiniz);
            this.Controls.Add(this.btn_Ayarlar);
            this.Controls.Add(this.btn_Raporlar);
            this.Controls.Add(this.btn_KategoriRaflar);
            this.Controls.Add(this.btn_Rezervasyon);
            this.Controls.Add(this.btn_OduncVerme);
            this.Controls.Add(this.btn_Turler);
            this.Controls.Add(this.btn_Yayinevi);
            this.Controls.Add(this.btn_Yazarlar);
            this.Controls.Add(this.btn_Sorumlular);
            this.Controls.Add(this.btn_Uyeler);
            this.Controls.Add(this.btn_Kitaplar);
            this.Name = "AnaMenuForm";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.AnaMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kitaplar;
        private System.Windows.Forms.Button btn_Uyeler;
        private System.Windows.Forms.Button btn_Sorumlular;
        private System.Windows.Forms.Button btn_Yazarlar;
        private System.Windows.Forms.Button btn_Yayinevi;
        private System.Windows.Forms.Button btn_Turler;
        private System.Windows.Forms.Button btn_OduncVerme;
        private System.Windows.Forms.Button btn_Rezervasyon;
        private System.Windows.Forms.Button btn_KategoriRaflar;
        private System.Windows.Forms.Button btn_Raporlar;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbl_Hosgeldiniz;
        private System.Windows.Forms.Button button1;
    }
}