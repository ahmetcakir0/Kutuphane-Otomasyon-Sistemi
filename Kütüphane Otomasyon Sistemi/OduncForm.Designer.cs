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
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_VerilenTarih = new System.Windows.Forms.DateTimePicker();
            this.txt_AlınacakKitap = new System.Windows.Forms.TextBox();
            this.btn_KitapAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_OduncListesi = new System.Windows.Forms.DataGridView();
            this.txt_AlacakKisi = new System.Windows.Forms.TextBox();
            this.btn_UyeAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IadeNotu = new System.Windows.Forms.TextBox();
            this.btn_IadeTemizle = new System.Windows.Forms.Button();
            this.btn_IadeKaydet = new System.Windows.Forms.Button();
            this.dgv_OduncIade = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_GeriVerilenTarih = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncIade)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1644, 1048);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Temizle);
            this.tabPage1.Controls.Add(this.btn_Kaydet);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dt_VerilenTarih);
            this.tabPage1.Controls.Add(this.txt_AlınacakKitap);
            this.tabPage1.Controls.Add(this.btn_KitapAra);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_OduncListesi);
            this.tabPage1.Controls.Add(this.txt_AlacakKisi);
            this.tabPage1.Controls.Add(this.btn_UyeAra);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1636, 1015);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ödünç Verme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(910, 382);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(177, 60);
            this.btn_Temizle.TabIndex = 76;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(544, 382);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(177, 60);
            this.btn_Kaydet.TabIndex = 74;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Verilen Tarih :";
            // 
            // dt_VerilenTarih
            // 
            this.dt_VerilenTarih.Location = new System.Drawing.Point(740, 215);
            this.dt_VerilenTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_VerilenTarih.Name = "dt_VerilenTarih";
            this.dt_VerilenTarih.Size = new System.Drawing.Size(310, 26);
            this.dt_VerilenTarih.TabIndex = 72;
            // 
            // txt_AlınacakKitap
            // 
            this.txt_AlınacakKitap.Location = new System.Drawing.Point(740, 140);
            this.txt_AlınacakKitap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AlınacakKitap.Name = "txt_AlınacakKitap";
            this.txt_AlınacakKitap.ReadOnly = true;
            this.txt_AlınacakKitap.Size = new System.Drawing.Size(236, 26);
            this.txt_AlınacakKitap.TabIndex = 71;
            // 
            // btn_KitapAra
            // 
            this.btn_KitapAra.ImageKey = "mercek.png";
            this.btn_KitapAra.ImageList = this.ımageList1;
            this.btn_KitapAra.Location = new System.Drawing.Point(987, 137);
            this.btn_KitapAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_KitapAra.Name = "btn_KitapAra";
            this.btn_KitapAra.Size = new System.Drawing.Size(64, 38);
            this.btn_KitapAra.TabIndex = 70;
            this.btn_KitapAra.UseVisualStyleBackColor = true;
            this.btn_KitapAra.Click += new System.EventHandler(this.btn_KitapAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Alınacak Kitap :";
            // 
            // dgv_OduncListesi
            // 
            this.dgv_OduncListesi.AllowUserToAddRows = false;
            this.dgv_OduncListesi.AllowUserToDeleteRows = false;
            this.dgv_OduncListesi.AllowUserToResizeColumns = false;
            this.dgv_OduncListesi.AllowUserToResizeRows = false;
            this.dgv_OduncListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OduncListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_OduncListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OduncListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_OduncListesi.Location = new System.Drawing.Point(4, 502);
            this.dgv_OduncListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_OduncListesi.MultiSelect = false;
            this.dgv_OduncListesi.Name = "dgv_OduncListesi";
            this.dgv_OduncListesi.ReadOnly = true;
            this.dgv_OduncListesi.RowHeadersVisible = false;
            this.dgv_OduncListesi.RowHeadersWidth = 62;
            this.dgv_OduncListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OduncListesi.Size = new System.Drawing.Size(1628, 508);
            this.dgv_OduncListesi.TabIndex = 68;
            this.dgv_OduncListesi.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_OduncListesi_ColumnHeaderMouseClick);
            // 
            // txt_AlacakKisi
            // 
            this.txt_AlacakKisi.Location = new System.Drawing.Point(740, 62);
            this.txt_AlacakKisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AlacakKisi.Name = "txt_AlacakKisi";
            this.txt_AlacakKisi.ReadOnly = true;
            this.txt_AlacakKisi.Size = new System.Drawing.Size(236, 26);
            this.txt_AlacakKisi.TabIndex = 67;
            // 
            // btn_UyeAra
            // 
            this.btn_UyeAra.ImageKey = "mercek.png";
            this.btn_UyeAra.ImageList = this.ımageList1;
            this.btn_UyeAra.Location = new System.Drawing.Point(987, 58);
            this.btn_UyeAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UyeAra.Name = "btn_UyeAra";
            this.btn_UyeAra.Size = new System.Drawing.Size(64, 38);
            this.btn_UyeAra.TabIndex = 66;
            this.btn_UyeAra.UseVisualStyleBackColor = true;
            this.btn_UyeAra.Click += new System.EventHandler(this.btn_UyeAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Alacak Üye :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_IadeNotu);
            this.tabPage2.Controls.Add(this.btn_IadeTemizle);
            this.tabPage2.Controls.Add(this.btn_IadeKaydet);
            this.tabPage2.Controls.Add(this.dgv_OduncIade);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dt_GeriVerilenTarih);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1636, 1015);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödünç İade";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Not .";
            // 
            // txt_IadeNotu
            // 
            this.txt_IadeNotu.Location = new System.Drawing.Point(704, 148);
            this.txt_IadeNotu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IadeNotu.Multiline = true;
            this.txt_IadeNotu.Name = "txt_IadeNotu";
            this.txt_IadeNotu.Size = new System.Drawing.Size(337, 187);
            this.txt_IadeNotu.TabIndex = 80;
            // 
            // btn_IadeTemizle
            // 
            this.btn_IadeTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IadeTemizle.Location = new System.Drawing.Point(962, 397);
            this.btn_IadeTemizle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_IadeTemizle.Name = "btn_IadeTemizle";
            this.btn_IadeTemizle.Size = new System.Drawing.Size(177, 60);
            this.btn_IadeTemizle.TabIndex = 79;
            this.btn_IadeTemizle.Text = "TEMİZLE";
            this.btn_IadeTemizle.UseVisualStyleBackColor = true;
            // 
            // btn_IadeKaydet
            // 
            this.btn_IadeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IadeKaydet.Location = new System.Drawing.Point(502, 397);
            this.btn_IadeKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_IadeKaydet.Name = "btn_IadeKaydet";
            this.btn_IadeKaydet.Size = new System.Drawing.Size(177, 60);
            this.btn_IadeKaydet.TabIndex = 77;
            this.btn_IadeKaydet.Text = "KAYDET";
            this.btn_IadeKaydet.UseVisualStyleBackColor = true;
            this.btn_IadeKaydet.Click += new System.EventHandler(this.btn_IadeKaydet_Click);
            // 
            // dgv_OduncIade
            // 
            this.dgv_OduncIade.AllowUserToAddRows = false;
            this.dgv_OduncIade.AllowUserToDeleteRows = false;
            this.dgv_OduncIade.AllowUserToResizeColumns = false;
            this.dgv_OduncIade.AllowUserToResizeRows = false;
            this.dgv_OduncIade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OduncIade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OduncIade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_OduncIade.Location = new System.Drawing.Point(4, 538);
            this.dgv_OduncIade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_OduncIade.MultiSelect = false;
            this.dgv_OduncIade.Name = "dgv_OduncIade";
            this.dgv_OduncIade.ReadOnly = true;
            this.dgv_OduncIade.RowHeadersWidth = 62;
            this.dgv_OduncIade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OduncIade.Size = new System.Drawing.Size(1628, 472);
            this.dgv_OduncIade.TabIndex = 76;
            this.dgv_OduncIade.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_OduncIade_ColumnHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Geri Verilen Tarih :";
            // 
            // dt_GeriVerilenTarih
            // 
            this.dt_GeriVerilenTarih.Location = new System.Drawing.Point(704, 45);
            this.dt_GeriVerilenTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_GeriVerilenTarih.Name = "dt_GeriVerilenTarih";
            this.dt_GeriVerilenTarih.Size = new System.Drawing.Size(337, 26);
            this.dt_GeriVerilenTarih.TabIndex = 73;
            // 
            // OduncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1048);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OduncForm";
            this.Text = "Ödünç Verme";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncIade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_VerilenTarih;
        private System.Windows.Forms.TextBox txt_AlınacakKitap;
        private System.Windows.Forms.Button btn_KitapAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_OduncListesi;
        private System.Windows.Forms.TextBox txt_AlacakKisi;
        private System.Windows.Forms.Button btn_UyeAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dt_GeriVerilenTarih;
        private System.Windows.Forms.DataGridView dgv_OduncIade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_IadeTemizle;
        private System.Windows.Forms.Button btn_IadeKaydet;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IadeNotu;
    }
}