namespace Kutuphane_Otomasyon_Sistemi
{
    partial class YazarKayitForm
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
            this.txt_YazarAdSoyad = new System.Windows.Forms.TextBox();
            this.txt_Iletisim = new System.Windows.Forms.TextBox();
            this.txt_Biyografi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_YazarListesi = new System.Windows.Forms.DataGridView();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.dtp_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YazarListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_YazarAdSoyad
            // 
            this.txt_YazarAdSoyad.Location = new System.Drawing.Point(566, 80);
            this.txt_YazarAdSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_YazarAdSoyad.Name = "txt_YazarAdSoyad";
            this.txt_YazarAdSoyad.Size = new System.Drawing.Size(236, 26);
            this.txt_YazarAdSoyad.TabIndex = 21;
            this.txt_YazarAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YazarAdSoyad_KeyPress);
            // 
            // txt_Iletisim
            // 
            this.txt_Iletisim.Location = new System.Drawing.Point(566, 171);
            this.txt_Iletisim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Iletisim.Name = "txt_Iletisim";
            this.txt_Iletisim.Size = new System.Drawing.Size(236, 26);
            this.txt_Iletisim.TabIndex = 22;
            // 
            // txt_Biyografi
            // 
            this.txt_Biyografi.Location = new System.Drawing.Point(970, 69);
            this.txt_Biyografi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Biyografi.Multiline = true;
            this.txt_Biyografi.Name = "txt_Biyografi";
            this.txt_Biyografi.Size = new System.Drawing.Size(474, 221);
            this.txt_Biyografi.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Yazar Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "İletişim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Biyografi :";
            // 
            // dgv_YazarListesi
            // 
            this.dgv_YazarListesi.AllowUserToAddRows = false;
            this.dgv_YazarListesi.AllowUserToDeleteRows = false;
            this.dgv_YazarListesi.AllowUserToResizeColumns = false;
            this.dgv_YazarListesi.AllowUserToResizeRows = false;
            this.dgv_YazarListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_YazarListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_YazarListesi.Location = new System.Drawing.Point(0, 466);
            this.dgv_YazarListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_YazarListesi.MultiSelect = false;
            this.dgv_YazarListesi.Name = "dgv_YazarListesi";
            this.dgv_YazarListesi.ReadOnly = true;
            this.dgv_YazarListesi.RowHeadersVisible = false;
            this.dgv_YazarListesi.RowHeadersWidth = 62;
            this.dgv_YazarListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_YazarListesi.Size = new System.Drawing.Size(1604, 535);
            this.dgv_YazarListesi.TabIndex = 42;
            this.dgv_YazarListesi.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_YazarListesi_ColumnHeaderMouseClick);
            this.dgv_YazarListesi.Click += new System.EventHandler(this.dgv_YazarListesi_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(518, 354);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(177, 60);
            this.btn_Kaydet.TabIndex = 40;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(536, 245);
            this.dtp_DogumTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(298, 26);
            this.dtp_DogumTarihi.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1065, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 60);
            this.button1.TabIndex = 46;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YazarKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 1002);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_DogumTarihi);
            this.Controls.Add(this.dgv_YazarListesi);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Biyografi);
            this.Controls.Add(this.txt_Iletisim);
            this.Controls.Add(this.txt_YazarAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "YazarKayitForm";
            this.Text = "Yazarlar";
            this.Load += new System.EventHandler(this.YazarKayitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YazarListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_YazarAdSoyad;
        private System.Windows.Forms.TextBox txt_Iletisim;
        private System.Windows.Forms.TextBox txt_Biyografi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_YazarListesi;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.DateTimePicker dtp_DogumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}