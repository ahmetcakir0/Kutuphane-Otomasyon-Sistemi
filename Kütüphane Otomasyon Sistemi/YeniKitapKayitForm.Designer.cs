namespace Kütüphane_Otomasyon_Sistemi
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
            this.dgv_KitapListesi = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_KitapAdi = new System.Windows.Forms.TextBox();
            this.cb_Tur = new System.Windows.Forms.ComboBox();
            this.cb_Yayinevi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Kategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SayfaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Yazar = new System.Windows.Forms.TextBox();
            this.btn_KitapAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Sil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RafNumarasi = new System.Windows.Forms.TextBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KitapListesi
            // 
            this.dgv_KitapListesi.AllowUserToAddRows = false;
            this.dgv_KitapListesi.AllowUserToDeleteRows = false;
            this.dgv_KitapListesi.AllowUserToResizeColumns = false;
            this.dgv_KitapListesi.AllowUserToResizeRows = false;
            this.dgv_KitapListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KitapListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_KitapListesi.Location = new System.Drawing.Point(0, 423);
            this.dgv_KitapListesi.MultiSelect = false;
            this.dgv_KitapListesi.Name = "dgv_KitapListesi";
            this.dgv_KitapListesi.ReadOnly = true;
            this.dgv_KitapListesi.RowHeadersVisible = false;
            this.dgv_KitapListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KitapListesi.Size = new System.Drawing.Size(1284, 261);
            this.dgv_KitapListesi.TabIndex = 0;
            this.dgv_KitapListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KitapListesi_CellClick);
            this.dgv_KitapListesi.DoubleClick += new System.EventHandler(this.dgv_KitapListesi_DoubleClick);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(811, 333);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(118, 39);
            this.btn_Temizle.TabIndex = 40;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tür :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kitap Adı :";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(453, 333);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 35;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_KitapAdi
            // 
            this.txt_KitapAdi.Location = new System.Drawing.Point(253, 61);
            this.txt_KitapAdi.Name = "txt_KitapAdi";
            this.txt_KitapAdi.Size = new System.Drawing.Size(159, 20);
            this.txt_KitapAdi.TabIndex = 31;
            // 
            // cb_Tur
            // 
            this.cb_Tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tur.FormattingEnabled = true;
            this.cb_Tur.Location = new System.Drawing.Point(712, 61);
            this.cb_Tur.Name = "cb_Tur";
            this.cb_Tur.Size = new System.Drawing.Size(159, 21);
            this.cb_Tur.TabIndex = 41;
            // 
            // cb_Yayinevi
            // 
            this.cb_Yayinevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Yayinevi.FormattingEnabled = true;
            this.cb_Yayinevi.Location = new System.Drawing.Point(253, 182);
            this.cb_Yayinevi.Name = "cb_Yayinevi";
            this.cb_Yayinevi.Size = new System.Drawing.Size(159, 21);
            this.cb_Yayinevi.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Yayınevi :";
            // 
            // cb_Kategori
            // 
            this.cb_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Kategori.FormattingEnabled = true;
            this.cb_Kategori.Location = new System.Drawing.Point(253, 256);
            this.cb_Kategori.Name = "cb_Kategori";
            this.cb_Kategori.Size = new System.Drawing.Size(159, 21);
            this.cb_Kategori.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kategori :";
            // 
            // txt_SayfaSayisi
            // 
            this.txt_SayfaSayisi.Location = new System.Drawing.Point(712, 124);
            this.txt_SayfaSayisi.Name = "txt_SayfaSayisi";
            this.txt_SayfaSayisi.Size = new System.Drawing.Size(159, 20);
            this.txt_SayfaSayisi.TabIndex = 34;
            this.txt_SayfaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SayfaSayisi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "ISBN :";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(712, 184);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(159, 20);
            this.txt_ISBN.TabIndex = 46;
            this.txt_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ISBN_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Yazar :";
            // 
            // txt_Yazar
            // 
            this.txt_Yazar.Location = new System.Drawing.Point(251, 121);
            this.txt_Yazar.Name = "txt_Yazar";
            this.txt_Yazar.ReadOnly = true;
            this.txt_Yazar.Size = new System.Drawing.Size(159, 20);
            this.txt_Yazar.TabIndex = 48;
            // 
            // btn_KitapAra
            // 
            this.btn_KitapAra.ImageKey = "mercek.png";
            this.btn_KitapAra.ImageList = this.ımageList1;
            this.btn_KitapAra.Location = new System.Drawing.Point(416, 118);
            this.btn_KitapAra.Name = "btn_KitapAra";
            this.btn_KitapAra.Size = new System.Drawing.Size(43, 25);
            this.btn_KitapAra.TabIndex = 57;
            this.btn_KitapAra.UseVisualStyleBackColor = true;
            this.btn_KitapAra.Click += new System.EventHandler(this.btn_KitapAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(633, 333);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(118, 39);
            this.btn_Sil.TabIndex = 58;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Raf Numarası :";
            // 
            // txt_RafNumarasi
            // 
            this.txt_RafNumarasi.Location = new System.Drawing.Point(712, 252);
            this.txt_RafNumarasi.Name = "txt_RafNumarasi";
            this.txt_RafNumarasi.ReadOnly = true;
            this.txt_RafNumarasi.Size = new System.Drawing.Size(159, 20);
            this.txt_RafNumarasi.TabIndex = 59;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(1017, 75);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(262, 197);
            this.txt_Aciklama.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(942, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Açıklama :";
            // 
            // YeniKitapKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 684);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_RafNumarasi);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_KitapAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Yazar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.cb_Kategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Yayinevi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Tur);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_SayfaSayisi);
            this.Controls.Add(this.txt_KitapAdi);
            this.Controls.Add(this.dgv_KitapListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YeniKitapKayitForm";
            this.Text = "YeniKitapKayitForm";
            this.Load += new System.EventHandler(this.YeniKitapKayitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KitapListesi;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_KitapAdi;
        private System.Windows.Forms.ComboBox cb_Tur;
        private System.Windows.Forms.ComboBox cb_Yayinevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Kategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SayfaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Yazar;
        private System.Windows.Forms.Button btn_KitapAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_RafNumarasi;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label9;
    }
}