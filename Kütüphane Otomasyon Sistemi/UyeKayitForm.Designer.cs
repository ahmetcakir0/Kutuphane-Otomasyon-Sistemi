namespace Kutuphane_Otomasyon_Sistemi
{
    partial class UyeKayitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_TCKimlik = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_TelNo = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.dtp_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.dgv_UyeListesi = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UyeListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TCKimlik
            // 
            this.txt_TCKimlik.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_TCKimlik.Location = new System.Drawing.Point(145, 69);
            this.txt_TCKimlik.Name = "txt_TCKimlik";
            this.txt_TCKimlik.Size = new System.Drawing.Size(159, 20);
            this.txt_TCKimlik.TabIndex = 19;
            this.txt_TCKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TCKimlik_KeyPress);
            // 
            // txt_Ad
            // 
            this.txt_Ad.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_Ad.Location = new System.Drawing.Point(145, 138);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(159, 20);
            this.txt_Ad.TabIndex = 20;
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ad_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_Soyad.Location = new System.Drawing.Point(145, 217);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(159, 20);
            this.txt_Soyad.TabIndex = 21;
            this.txt_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // txt_TelNo
            // 
            this.txt_TelNo.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_TelNo.Location = new System.Drawing.Point(505, 73);
            this.txt_TelNo.Name = "txt_TelNo";
            this.txt_TelNo.Size = new System.Drawing.Size(159, 20);
            this.txt_TelNo.TabIndex = 22;
            this.txt_TelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TelNo_KeyPress);
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_Eposta.Location = new System.Drawing.Point(505, 138);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(159, 20);
            this.txt_Eposta.TabIndex = 23;
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(505, 214);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(159, 20);
            this.dtp_DogumTarihi.TabIndex = 24;
            // 
            // txt_Adres
            // 
            this.txt_Adres.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_Adres.Location = new System.Drawing.Point(785, 73);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(247, 116);
            this.txt_Adres.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(49, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(49, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(405, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tel No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(405, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "E - posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(405, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(739, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adres :";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(505, 293);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(118, 39);
            this.btn_Sil.TabIndex = 36;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(186, 293);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 35;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.Kaydet_Button_Click);
            // 
            // dgv_UyeListesi
            // 
            this.dgv_UyeListesi.AllowUserToAddRows = false;
            this.dgv_UyeListesi.AllowUserToDeleteRows = false;
            this.dgv_UyeListesi.AllowUserToResizeColumns = false;
            this.dgv_UyeListesi.AllowUserToResizeRows = false;
            this.dgv_UyeListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UyeListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_UyeListesi.BackgroundColor = System.Drawing.Color.Brown;
            this.dgv_UyeListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UyeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UyeListesi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UyeListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_UyeListesi.Location = new System.Drawing.Point(0, 417);
            this.dgv_UyeListesi.MultiSelect = false;
            this.dgv_UyeListesi.Name = "dgv_UyeListesi";
            this.dgv_UyeListesi.ReadOnly = true;
            this.dgv_UyeListesi.RowHeadersVisible = false;
            this.dgv_UyeListesi.RowHeadersWidth = 62;
            this.dgv_UyeListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UyeListesi.Size = new System.Drawing.Size(1123, 208);
            this.dgv_UyeListesi.TabIndex = 38;
            this.dgv_UyeListesi.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_UyeListesi_ColumnHeaderMouseClick);
            this.dgv_UyeListesi.DoubleClick += new System.EventHandler(this.dgv_UyeListesi_DoubleClick);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(856, 293);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(118, 39);
            this.btn_Temizle.TabIndex = 39;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // UyeKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1123, 625);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.dgv_UyeListesi);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.dtp_DogumTarihi);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_TelNo);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_TCKimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UyeKayitForm";
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.YeniUyeKayitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UyeListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TCKimlik;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_TelNo;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.DateTimePicker dtp_DogumTarihi;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.DataGridView dgv_UyeListesi;
        private System.Windows.Forms.Button btn_Temizle;
    }
}