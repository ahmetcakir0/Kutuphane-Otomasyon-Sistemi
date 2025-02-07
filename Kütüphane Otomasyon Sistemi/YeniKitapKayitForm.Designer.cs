namespace Kutuphane_Otomasyon_Sistemi
{
    partial class YeniKitapKayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKitapKayitForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekranlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Guncelle_Button = new System.Windows.Forms.Button();
            this.Sil_Button = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SayfaSayisi = new System.Windows.Forms.TextBox();
            this.txt_KitapAdi = new System.Windows.Forms.TextBox();
            this.cb_Yayinevi = new System.Windows.Forms.ComboBox();
            this.cb_KitapTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Kategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.dgv_KitapListesi = new System.Windows.Forms.DataGridView();
            this.txt_RafNumarasi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_YazarAdi = new System.Windows.Forms.TextBox();
            this.btn_OduncAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.raporkarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekranlarToolStripMenuItem
            // 
            this.ekranlarToolStripMenuItem.Name = "ekranlarToolStripMenuItem";
            this.ekranlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ekranlarToolStripMenuItem.Text = "Ekranlar";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // raporkarToolStripMenuItem
            // 
            this.raporkarToolStripMenuItem.Name = "raporkarToolStripMenuItem";
            this.raporkarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporkarToolStripMenuItem.Text = "Raporlar";
            // 
            // Guncelle_Button
            // 
            this.Guncelle_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle_Button.Location = new System.Drawing.Point(355, 322);
            this.Guncelle_Button.Name = "Guncelle_Button";
            this.Guncelle_Button.Size = new System.Drawing.Size(118, 39);
            this.Guncelle_Button.TabIndex = 34;
            this.Guncelle_Button.Text = "GÜNCELLE";
            this.Guncelle_Button.UseVisualStyleBackColor = true;
            // 
            // Sil_Button
            // 
            this.Sil_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_Button.Location = new System.Drawing.Point(544, 322);
            this.Sil_Button.Name = "Sil_Button";
            this.Sil_Button.Size = new System.Drawing.Size(118, 39);
            this.Sil_Button.TabIndex = 33;
            this.Sil_Button.Text = "SİL";
            this.Sil_Button.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(737, 322);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 32;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Kitap Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Yayınevi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sayfa Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Yazar Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kitabın Adı :";
            // 
            // txt_SayfaSayisi
            // 
            this.txt_SayfaSayisi.Location = new System.Drawing.Point(190, 194);
            this.txt_SayfaSayisi.Name = "txt_SayfaSayisi";
            this.txt_SayfaSayisi.Size = new System.Drawing.Size(159, 20);
            this.txt_SayfaSayisi.TabIndex = 20;
            // 
            // txt_KitapAdi
            // 
            this.txt_KitapAdi.Location = new System.Drawing.Point(190, 60);
            this.txt_KitapAdi.Name = "txt_KitapAdi";
            this.txt_KitapAdi.Size = new System.Drawing.Size(159, 20);
            this.txt_KitapAdi.TabIndex = 18;
            // 
            // cb_Yayinevi
            // 
            this.cb_Yayinevi.FormattingEnabled = true;
            this.cb_Yayinevi.Location = new System.Drawing.Point(544, 63);
            this.cb_Yayinevi.Name = "cb_Yayinevi";
            this.cb_Yayinevi.Size = new System.Drawing.Size(159, 21);
            this.cb_Yayinevi.TabIndex = 35;
            // 
            // cb_KitapTuru
            // 
            this.cb_KitapTuru.FormattingEnabled = true;
            this.cb_KitapTuru.Location = new System.Drawing.Point(544, 130);
            this.cb_KitapTuru.Name = "cb_KitapTuru";
            this.cb_KitapTuru.Size = new System.Drawing.Size(159, 21);
            this.cb_KitapTuru.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Kategori :";
            // 
            // cb_Kategori
            // 
            this.cb_Kategori.FormattingEnabled = true;
            this.cb_Kategori.Location = new System.Drawing.Point(544, 194);
            this.cb_Kategori.Name = "cb_Kategori";
            this.cb_Kategori.Size = new System.Drawing.Size(159, 21);
            this.cb_Kategori.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "ISBN :";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(909, 64);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(159, 20);
            this.txt_ISBN.TabIndex = 40;
            // 
            // dgv_KitapListesi
            // 
            this.dgv_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KitapListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_KitapListesi.Location = new System.Drawing.Point(0, 433);
            this.dgv_KitapListesi.Name = "dgv_KitapListesi";
            this.dgv_KitapListesi.Size = new System.Drawing.Size(1134, 209);
            this.dgv_KitapListesi.TabIndex = 43;
            // 
            // txt_RafNumarasi
            // 
            this.txt_RafNumarasi.Location = new System.Drawing.Point(909, 124);
            this.txt_RafNumarasi.Name = "txt_RafNumarasi";
            this.txt_RafNumarasi.Size = new System.Drawing.Size(159, 20);
            this.txt_RafNumarasi.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(809, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(817, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Raf Numarası :";
            // 
            // txt_YazarAdi
            // 
            this.txt_YazarAdi.Location = new System.Drawing.Point(190, 131);
            this.txt_YazarAdi.Name = "txt_YazarAdi";
            this.txt_YazarAdi.Size = new System.Drawing.Size(159, 20);
            this.txt_YazarAdi.TabIndex = 61;
            // 
            // btn_OduncAra
            // 
            this.btn_OduncAra.ImageKey = "mercek.png";
            this.btn_OduncAra.ImageList = this.ımageList1;
            this.btn_OduncAra.Location = new System.Drawing.Point(355, 129);
            this.btn_OduncAra.Name = "btn_OduncAra";
            this.btn_OduncAra.Size = new System.Drawing.Size(43, 25);
            this.btn_OduncAra.TabIndex = 60;
            this.btn_OduncAra.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // YeniKitapKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 642);
            this.Controls.Add(this.txt_YazarAdi);
            this.Controls.Add(this.btn_OduncAra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_RafNumarasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_KitapListesi);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_Kategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_KitapTuru);
            this.Controls.Add(this.cb_Yayinevi);
            this.Controls.Add(this.Guncelle_Button);
            this.Controls.Add(this.Sil_Button);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SayfaSayisi);
            this.Controls.Add(this.txt_KitapAdi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YeniKitapKayitForm";
            this.Text = "Yeni Kitap Kayıt";
            this.Load += new System.EventHandler(this.YeniKitapKayitForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekranlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporkarToolStripMenuItem;
        private System.Windows.Forms.Button Guncelle_Button;
        private System.Windows.Forms.Button Sil_Button;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SayfaSayisi;
        private System.Windows.Forms.TextBox txt_KitapAdi;
        private System.Windows.Forms.ComboBox cb_Yayinevi;
        private System.Windows.Forms.ComboBox cb_KitapTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Kategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.DataGridView dgv_KitapListesi;
        private System.Windows.Forms.TextBox txt_RafNumarasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_YazarAdi;
        private System.Windows.Forms.Button btn_OduncAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}