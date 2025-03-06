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
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_VerilenTarih = new System.Windows.Forms.DateTimePicker();
            this.txt_AlınacakKitap = new System.Windows.Forms.TextBox();
            this.btn_KitapAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_OduncListesi = new System.Windows.Forms.DataGridView();
            this.txt_AlacakKisi = new System.Windows.Forms.TextBox();
            this.btn_UyeAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_VerilmesiGerekenTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_RezervasyonUye = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Guncelle);
            this.tabPage1.Controls.Add(this.btn_Sil);
            this.tabPage1.Controls.Add(this.btn_Kaydet);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dt_VerilenTarih);
            this.tabPage1.Controls.Add(this.txt_AlınacakKitap);
            this.tabPage1.Controls.Add(this.btn_KitapAra);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_OduncListesi);
            this.tabPage1.Controls.Add(this.txt_AlacakKisi);
            this.tabPage1.Controls.Add(this.btn_UyeAra);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dt_VerilmesiGerekenTarih);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ödünç Verme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(660, 248);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(118, 39);
            this.btn_Guncelle.TabIndex = 76;
            this.btn_Guncelle.Text = "TEMİZLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(487, 248);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(118, 39);
            this.btn_Sil.TabIndex = 75;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(310, 248);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 74;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Verilen Tarih :";
            // 
            // dt_VerilenTarih
            // 
            this.dt_VerilenTarih.Location = new System.Drawing.Point(497, 122);
            this.dt_VerilenTarih.Name = "dt_VerilenTarih";
            this.dt_VerilenTarih.Size = new System.Drawing.Size(208, 20);
            this.dt_VerilenTarih.TabIndex = 72;
            // 
            // txt_AlınacakKitap
            // 
            this.txt_AlınacakKitap.Location = new System.Drawing.Point(497, 73);
            this.txt_AlınacakKitap.Name = "txt_AlınacakKitap";
            this.txt_AlınacakKitap.Size = new System.Drawing.Size(159, 20);
            this.txt_AlınacakKitap.TabIndex = 71;
            // 
            // btn_KitapAra
            // 
            this.btn_KitapAra.ImageKey = "mercek.png";
            this.btn_KitapAra.ImageList = this.ımageList1;
            this.btn_KitapAra.Location = new System.Drawing.Point(662, 71);
            this.btn_KitapAra.Name = "btn_KitapAra";
            this.btn_KitapAra.Size = new System.Drawing.Size(43, 25);
            this.btn_KitapAra.TabIndex = 70;
            this.btn_KitapAra.UseVisualStyleBackColor = true;
            this.btn_KitapAra.Click += new System.EventHandler(this.btn_KitapAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Alınacak Kitap :";
            // 
            // dgv_OduncListesi
            // 
            this.dgv_OduncListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OduncListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_OduncListesi.Location = new System.Drawing.Point(3, 322);
            this.dgv_OduncListesi.Name = "dgv_OduncListesi";
            this.dgv_OduncListesi.Size = new System.Drawing.Size(1082, 330);
            this.dgv_OduncListesi.TabIndex = 68;
            // 
            // txt_AlacakKisi
            // 
            this.txt_AlacakKisi.Location = new System.Drawing.Point(497, 22);
            this.txt_AlacakKisi.Name = "txt_AlacakKisi";
            this.txt_AlacakKisi.Size = new System.Drawing.Size(159, 20);
            this.txt_AlacakKisi.TabIndex = 67;
            // 
            // btn_UyeAra
            // 
            this.btn_UyeAra.ImageKey = "mercek.png";
            this.btn_UyeAra.ImageList = this.ımageList1;
            this.btn_UyeAra.Location = new System.Drawing.Point(662, 20);
            this.btn_UyeAra.Name = "btn_UyeAra";
            this.btn_UyeAra.Size = new System.Drawing.Size(43, 25);
            this.btn_UyeAra.TabIndex = 66;
            this.btn_UyeAra.UseVisualStyleBackColor = true;
            this.btn_UyeAra.Click += new System.EventHandler(this.btn_UyeAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Geri Verilmesi Gereken Tarih :";
            // 
            // dt_VerilmesiGerekenTarih
            // 
            this.dt_VerilmesiGerekenTarih.Location = new System.Drawing.Point(497, 164);
            this.dt_VerilmesiGerekenTarih.Name = "dt_VerilmesiGerekenTarih";
            this.dt_VerilmesiGerekenTarih.Size = new System.Drawing.Size(208, 20);
            this.dt_VerilmesiGerekenTarih.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Alacak Üye :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_RezervasyonUye);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödünç İade";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_RezervasyonUye
            // 
            this.txt_RezervasyonUye.Location = new System.Drawing.Point(450, 63);
            this.txt_RezervasyonUye.Name = "txt_RezervasyonUye";
            this.txt_RezervasyonUye.Size = new System.Drawing.Size(159, 20);
            this.txt_RezervasyonUye.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.ImageKey = "mercek.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(615, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ödünç :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Geri Verilen Tarih :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 307);
            this.dataGridView1.TabIndex = 76;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(660, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 79;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(487, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 39);
            this.button3.TabIndex = 78;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(310, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 39);
            this.button4.TabIndex = 77;
            this.button4.Text = "KAYDET";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // OduncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "OduncForm";
            this.Text = "Ödünç Verme";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_VerilenTarih;
        private System.Windows.Forms.TextBox txt_AlınacakKitap;
        private System.Windows.Forms.Button btn_KitapAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_OduncListesi;
        private System.Windows.Forms.TextBox txt_AlacakKisi;
        private System.Windows.Forms.Button btn_UyeAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_VerilmesiGerekenTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_RezervasyonUye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}