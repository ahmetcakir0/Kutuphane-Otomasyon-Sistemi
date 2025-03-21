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
            this.btn_KategoriRaflar = new System.Windows.Forms.Button();
            this.lbl_Hosgeldiniz = new System.Windows.Forms.Label();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kitaplar
            // 
            this.btn_Kitaplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Kitaplar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kitaplar.ImageKey = "depositphotos_270747206-stock-illustration-stack-books-cartoon-illustration-stack" +
    ".jpg";
            this.btn_Kitaplar.ImageList = this.ımageList1;
            this.btn_Kitaplar.Location = new System.Drawing.Point(207, 112);
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
            this.btn_Uyeler.Location = new System.Drawing.Point(476, 112);
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
            this.btn_Sorumlular.Location = new System.Drawing.Point(748, 112);
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
            this.btn_Yazarlar.Location = new System.Drawing.Point(1017, 112);
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
            this.btn_Yayinevi.Location = new System.Drawing.Point(207, 335);
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
            this.btn_Turler.Location = new System.Drawing.Point(481, 335);
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
            this.btn_OduncVerme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OduncVerme.BackColor = System.Drawing.Color.Transparent;
            this.btn_OduncVerme.ImageKey = "boy-with-glasses-lends-a-book-to-his-friend-vector.jpg";
            this.btn_OduncVerme.ImageList = this.ımageList1;
            this.btn_OduncVerme.Location = new System.Drawing.Point(1017, 335);
            this.btn_OduncVerme.Name = "btn_OduncVerme";
            this.btn_OduncVerme.Size = new System.Drawing.Size(214, 141);
            this.btn_OduncVerme.TabIndex = 6;
            this.btn_OduncVerme.Text = "ÖDÜNÇ";
            this.btn_OduncVerme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_OduncVerme.UseVisualStyleBackColor = false;
            this.btn_OduncVerme.Click += new System.EventHandler(this.btn_OduncVerme_Click);
            // 
            // btn_KategoriRaflar
            // 
            this.btn_KategoriRaflar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_KategoriRaflar.BackColor = System.Drawing.Color.Transparent;
            this.btn_KategoriRaflar.ImageKey = "duvar-resimleri-kutuphane-kitap-raf-arka-plan-vektor.jpg.jpg";
            this.btn_KategoriRaflar.ImageList = this.ımageList1;
            this.btn_KategoriRaflar.Location = new System.Drawing.Point(748, 335);
            this.btn_KategoriRaflar.Name = "btn_KategoriRaflar";
            this.btn_KategoriRaflar.Size = new System.Drawing.Size(214, 141);
            this.btn_KategoriRaflar.TabIndex = 9;
            this.btn_KategoriRaflar.Text = "KATEGORİ / RAFLAR";
            this.btn_KategoriRaflar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_KategoriRaflar.UseVisualStyleBackColor = false;
            this.btn_KategoriRaflar.Click += new System.EventHandler(this.btn_KategoriRaflar_Click);
            // 
            // lbl_Hosgeldiniz
            // 
            this.lbl_Hosgeldiniz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Hosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Hosgeldiniz.Location = new System.Drawing.Point(476, 59);
            this.lbl_Hosgeldiniz.Name = "lbl_Hosgeldiniz";
            this.lbl_Hosgeldiniz.Size = new System.Drawing.Size(486, 30);
            this.lbl_Hosgeldiniz.TabIndex = 12;
            this.lbl_Hosgeldiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Hosgeldiniz.Click += new System.EventHandler(this.lbl_Hosgeldiniz_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervasyon.ImageKey = "istockphoto-1296390218-612x612.jpg";
            this.btnRezervasyon.ImageList = this.ımageList1;
            this.btnRezervasyon.Location = new System.Drawing.Point(207, 561);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(214, 141);
            this.btnRezervasyon.TabIndex = 14;
            this.btnRezervasyon.Text = "REZERVASYON";
            this.btnRezervasyon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRaporlar.BackColor = System.Drawing.Color.Transparent;
            this.btnRaporlar.ImageKey = "pngtree-checklist-comic-icon-for-reports-and-business-check-evaluation-analysis-v" +
    "ector-png-image_12861732.png";
            this.btnRaporlar.ImageList = this.ımageList1;
            this.btnRaporlar.Location = new System.Drawing.Point(481, 561);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(214, 141);
            this.btnRaporlar.TabIndex = 15;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.ImageKey = "settings-icon_2691259.jpg";
            this.btnAyarlar.ImageList = this.ımageList1;
            this.btnAyarlar.Location = new System.Drawing.Point(748, 561);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(214, 141);
            this.btnAyarlar.TabIndex = 16;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.ImageKey = "Çıkış.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(1017, 561);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(214, 141);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 776);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.lbl_Hosgeldiniz);
            this.Controls.Add(this.btn_KategoriRaflar);
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
        private System.Windows.Forms.Button btn_KategoriRaflar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbl_Hosgeldiniz;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;
    }
}