namespace Kutuphane_Otomasyon_Sistemi
{
    partial class RezervasyonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonForm));
            this.txt_RezervasyonUye = new System.Windows.Forms.TextBox();
            this.btn_UyeAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RezervasyonKitap = new System.Windows.Forms.TextBox();
            this.btn_KitapAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.dgv_Rezervasyon = new System.Windows.Forms.DataGridView();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_RezervasyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_RezervasyonUye
            // 
            this.txt_RezervasyonUye.Location = new System.Drawing.Point(156, 21);
            this.txt_RezervasyonUye.Name = "txt_RezervasyonUye";
            this.txt_RezervasyonUye.Size = new System.Drawing.Size(159, 20);
            this.txt_RezervasyonUye.TabIndex = 52;
            // 
            // btn_UyeAra
            // 
            this.btn_UyeAra.ImageKey = "mercek.png";
            this.btn_UyeAra.ImageList = this.ımageList1;
            this.btn_UyeAra.Location = new System.Drawing.Point(321, 19);
            this.btn_UyeAra.Name = "btn_UyeAra";
            this.btn_UyeAra.Size = new System.Drawing.Size(61, 23);
            this.btn_UyeAra.TabIndex = 51;
            this.btn_UyeAra.UseVisualStyleBackColor = true;
            this.btn_UyeAra.Click += new System.EventHandler(this.btn_UyeAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Üye :";
            // 
            // txt_RezervasyonKitap
            // 
            this.txt_RezervasyonKitap.Location = new System.Drawing.Point(156, 68);
            this.txt_RezervasyonKitap.Name = "txt_RezervasyonKitap";
            this.txt_RezervasyonKitap.Size = new System.Drawing.Size(159, 20);
            this.txt_RezervasyonKitap.TabIndex = 55;
            // 
            // btn_KitapAra
            // 
            this.btn_KitapAra.ImageKey = "mercek.png";
            this.btn_KitapAra.ImageList = this.ımageList1;
            this.btn_KitapAra.Location = new System.Drawing.Point(321, 64);
            this.btn_KitapAra.Name = "btn_KitapAra";
            this.btn_KitapAra.Size = new System.Drawing.Size(61, 23);
            this.btn_KitapAra.TabIndex = 54;
            this.btn_KitapAra.UseVisualStyleBackColor = true;
            this.btn_KitapAra.Click += new System.EventHandler(this.btn_KitapAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Kitap :";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(197, 284);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(118, 39);
            this.btn_Sil.TabIndex = 57;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(32, 284);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 56;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click_1);
            // 
            // dgv_Rezervasyon
            // 
            this.dgv_Rezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rezervasyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Rezervasyon.Location = new System.Drawing.Point(0, 343);
            this.dgv_Rezervasyon.Name = "dgv_Rezervasyon";
            this.dgv_Rezervasyon.ReadOnly = true;
            this.dgv_Rezervasyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Rezervasyon.Size = new System.Drawing.Size(513, 246);
            this.dgv_Rezervasyon.TabIndex = 59;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(156, 163);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(226, 79);
            this.txt_Aciklama.TabIndex = 60;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(365, 284);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(118, 39);
            this.btn_Temizle.TabIndex = 61;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Aciklama :";
            // 
            // dtp_RezervasyonTarihi
            // 
            this.dtp_RezervasyonTarihi.Location = new System.Drawing.Point(156, 116);
            this.dtp_RezervasyonTarihi.Name = "dtp_RezervasyonTarihi";
            this.dtp_RezervasyonTarihi.Size = new System.Drawing.Size(226, 20);
            this.dtp_RezervasyonTarihi.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Rezervasyon Tarihi :";
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_RezervasyonTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.dgv_Rezervasyon);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_RezervasyonKitap);
            this.Controls.Add(this.btn_KitapAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RezervasyonUye);
            this.Controls.Add(this.btn_UyeAra);
            this.Controls.Add(this.label2);
            this.Name = "RezervasyonForm";
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rezervasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RezervasyonUye;
        private System.Windows.Forms.Button btn_UyeAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RezervasyonKitap;
        private System.Windows.Forms.Button btn_KitapAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.DataGridView dgv_Rezervasyon;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_RezervasyonTarihi;
        private System.Windows.Forms.Label label4;
    }
}