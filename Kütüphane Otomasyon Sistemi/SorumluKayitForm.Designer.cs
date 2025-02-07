namespace Kutuphane_Otomasyon_Sistemi
{
    partial class SorumluKayitForm
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
            this.txt_TCKimlik = new System.Windows.Forms.TextBox();
            this.txt_SorumluAd = new System.Windows.Forms.TextBox();
            this.txt_SorumluSoyad = new System.Windows.Forms.TextBox();
            this.txt_TelNo = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.dgv_SorumluListesi = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekranlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SorumluKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SorumluSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SorumluListesi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TCKimlik
            // 
            this.txt_TCKimlik.Location = new System.Drawing.Point(184, 90);
            this.txt_TCKimlik.Name = "txt_TCKimlik";
            this.txt_TCKimlik.Size = new System.Drawing.Size(159, 20);
            this.txt_TCKimlik.TabIndex = 0;
            // 
            // txt_SorumluAd
            // 
            this.txt_SorumluAd.Location = new System.Drawing.Point(184, 157);
            this.txt_SorumluAd.Name = "txt_SorumluAd";
            this.txt_SorumluAd.Size = new System.Drawing.Size(159, 20);
            this.txt_SorumluAd.TabIndex = 2;
            // 
            // txt_SorumluSoyad
            // 
            this.txt_SorumluSoyad.Location = new System.Drawing.Point(184, 224);
            this.txt_SorumluSoyad.Name = "txt_SorumluSoyad";
            this.txt_SorumluSoyad.Size = new System.Drawing.Size(159, 20);
            this.txt_SorumluSoyad.TabIndex = 3;
            // 
            // txt_TelNo
            // 
            this.txt_TelNo.Location = new System.Drawing.Point(547, 90);
            this.txt_TelNo.Name = "txt_TelNo";
            this.txt_TelNo.Size = new System.Drawing.Size(159, 20);
            this.txt_TelNo.TabIndex = 4;
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(547, 157);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(159, 20);
            this.txt_Eposta.TabIndex = 5;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(872, 157);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(159, 20);
            this.txt_Adres.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sorumlu Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sorumlu Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tel No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E - posta :";
            // 
            // dt_DogumTarihi
            // 
            this.dt_DogumTarihi.Location = new System.Drawing.Point(872, 90);
            this.dt_DogumTarihi.Name = "dt_DogumTarihi";
            this.dt_DogumTarihi.Size = new System.Drawing.Size(159, 20);
            this.dt_DogumTarihi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(757, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adres :";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(345, 300);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 15;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(522, 300);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(118, 39);
            this.btn_Sil.TabIndex = 16;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(695, 300);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(118, 39);
            this.btn_Guncelle.TabIndex = 17;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // dgv_SorumluListesi
            // 
            this.dgv_SorumluListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SorumluListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SorumluListesi.Location = new System.Drawing.Point(0, 379);
            this.dgv_SorumluListesi.Name = "dgv_SorumluListesi";
            this.dgv_SorumluListesi.Size = new System.Drawing.Size(1161, 207);
            this.dgv_SorumluListesi.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 19;
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
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kullanıcı Adı :";
            // 
            // txt_SorumluKullaniciAdi
            // 
            this.txt_SorumluKullaniciAdi.Location = new System.Drawing.Point(547, 224);
            this.txt_SorumluKullaniciAdi.Name = "txt_SorumluKullaniciAdi";
            this.txt_SorumluKullaniciAdi.Size = new System.Drawing.Size(159, 20);
            this.txt_SorumluKullaniciAdi.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(757, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Şifre :";
            // 
            // txt_SorumluSifre
            // 
            this.txt_SorumluSifre.Location = new System.Drawing.Point(872, 224);
            this.txt_SorumluSifre.Name = "txt_SorumluSifre";
            this.txt_SorumluSifre.Size = new System.Drawing.Size(159, 20);
            this.txt_SorumluSifre.TabIndex = 22;
            // 
            // SorumluKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 586);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SorumluSifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SorumluKullaniciAdi);
            this.Controls.Add(this.dgv_SorumluListesi);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_DogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_TelNo);
            this.Controls.Add(this.txt_SorumluSoyad);
            this.Controls.Add(this.txt_SorumluAd);
            this.Controls.Add(this.txt_TCKimlik);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SorumluKayitForm";
            this.Text = "Sorumlu Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SorumluListesi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TCKimlik;
        private System.Windows.Forms.TextBox txt_SorumluAd;
        private System.Windows.Forms.TextBox txt_SorumluSoyad;
        private System.Windows.Forms.TextBox txt_TelNo;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_DogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView dgv_SorumluListesi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekranlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SorumluKullaniciAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SorumluSifre;
    }
}