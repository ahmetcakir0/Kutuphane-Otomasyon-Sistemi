namespace Kutuphane_Otomasyon_Sistemi
{
    partial class OduncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekranlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_VerilmesiGerekenTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AlacakKisi = new System.Windows.Forms.TextBox();
            this.btn_OduncAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.dgv_OduncListesi = new System.Windows.Forms.DataGridView();
            this.txt_AlınacakKitap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_VerilenTarih = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alacak Üye :";
            // 
            // dt_VerilmesiGerekenTarih
            // 
            this.dt_VerilmesiGerekenTarih.Location = new System.Drawing.Point(518, 181);
            this.dt_VerilmesiGerekenTarih.Name = "dt_VerilmesiGerekenTarih";
            this.dt_VerilmesiGerekenTarih.Size = new System.Drawing.Size(159, 20);
            this.dt_VerilmesiGerekenTarih.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Geri Verilmesi Gereken Tarih :";
            // 
            // txt_AlacakKisi
            // 
            this.txt_AlacakKisi.Location = new System.Drawing.Point(497, 39);
            this.txt_AlacakKisi.Name = "txt_AlacakKisi";
            this.txt_AlacakKisi.Size = new System.Drawing.Size(159, 20);
            this.txt_AlacakKisi.TabIndex = 51;
            // 
            // btn_OduncAra
            // 
            this.btn_OduncAra.ImageKey = "mercek.png";
            this.btn_OduncAra.ImageList = this.ımageList1;
            this.btn_OduncAra.Location = new System.Drawing.Point(662, 37);
            this.btn_OduncAra.Name = "btn_OduncAra";
            this.btn_OduncAra.Size = new System.Drawing.Size(43, 25);
            this.btn_OduncAra.TabIndex = 50;
            this.btn_OduncAra.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guncelle.Location = new System.Drawing.Point(587, 246);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(118, 39);
            this.btn_Guncelle.TabIndex = 53;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(363, 246);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 52;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // dgv_OduncListesi
            // 
            this.dgv_OduncListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OduncListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_OduncListesi.Location = new System.Drawing.Point(0, 351);
            this.dgv_OduncListesi.Name = "dgv_OduncListesi";
            this.dgv_OduncListesi.Size = new System.Drawing.Size(1096, 330);
            this.dgv_OduncListesi.TabIndex = 54;
            // 
            // txt_AlınacakKitap
            // 
            this.txt_AlınacakKitap.Location = new System.Drawing.Point(497, 90);
            this.txt_AlınacakKitap.Name = "txt_AlınacakKitap";
            this.txt_AlınacakKitap.Size = new System.Drawing.Size(159, 20);
            this.txt_AlınacakKitap.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.ImageKey = "mercek.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(662, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Alınacak Kitap :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Verilen Tarih :";
            // 
            // dt_VerilenTarih
            // 
            this.dt_VerilenTarih.Location = new System.Drawing.Point(518, 139);
            this.dt_VerilenTarih.Name = "dt_VerilenTarih";
            this.dt_VerilenTarih.Size = new System.Drawing.Size(159, 20);
            this.dt_VerilenTarih.TabIndex = 58;
            // 
            // OduncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_VerilenTarih);
            this.Controls.Add(this.txt_AlınacakKitap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_OduncListesi);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_AlacakKisi);
            this.Controls.Add(this.btn_OduncAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_VerilmesiGerekenTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "OduncForm";
            this.Text = "Ödünç Verme";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekranlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporkarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_VerilmesiGerekenTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AlacakKisi;
        private System.Windows.Forms.Button btn_OduncAra;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.DataGridView dgv_OduncListesi;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txt_AlınacakKitap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_VerilenTarih;
    }
}