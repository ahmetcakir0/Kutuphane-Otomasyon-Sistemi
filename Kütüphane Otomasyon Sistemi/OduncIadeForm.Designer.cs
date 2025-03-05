namespace Kütüphane_Otomasyon_Sistemi
{
    partial class OduncIadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncIadeForm));
            this.label4 = new System.Windows.Forms.Label();
            this.dt_VerilmesiGereken = new System.Windows.Forms.DateTimePicker();
            this.dgv_IadeListesi = new System.Windows.Forms.DataGridView();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_IadeEdilecekOdunc = new System.Windows.Forms.TextBox();
            this.btn_OduncAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dt_GeriVerilen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IadeListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Geri Verilmesi Gereken Tarih :";
            // 
            // dt_VerilmesiGereken
            // 
            this.dt_VerilmesiGereken.Location = new System.Drawing.Point(581, 110);
            this.dt_VerilmesiGereken.Name = "dt_VerilmesiGereken";
            this.dt_VerilmesiGereken.Size = new System.Drawing.Size(159, 20);
            this.dt_VerilmesiGereken.TabIndex = 72;
            // 
            // dgv_IadeListesi
            // 
            this.dgv_IadeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IadeListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_IadeListesi.Location = new System.Drawing.Point(0, 340);
            this.dgv_IadeListesi.Name = "dgv_IadeListesi";
            this.dgv_IadeListesi.Size = new System.Drawing.Size(1198, 330);
            this.dgv_IadeListesi.TabIndex = 68;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(639, 243);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(118, 39);
            this.btn_Guncelle.TabIndex = 67;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(415, 243);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 66;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // txt_IadeEdilecekOdunc
            // 
            this.txt_IadeEdilecekOdunc.Location = new System.Drawing.Point(560, 69);
            this.txt_IadeEdilecekOdunc.Name = "txt_IadeEdilecekOdunc";
            this.txt_IadeEdilecekOdunc.Size = new System.Drawing.Size(159, 20);
            this.txt_IadeEdilecekOdunc.TabIndex = 65;
            // 
            // btn_OduncAra
            // 
            this.btn_OduncAra.ImageKey = "mercek.png";
            this.btn_OduncAra.ImageList = this.ımageList1;
            this.btn_OduncAra.Location = new System.Drawing.Point(725, 67);
            this.btn_OduncAra.Name = "btn_OduncAra";
            this.btn_OduncAra.Size = new System.Drawing.Size(43, 25);
            this.btn_OduncAra.TabIndex = 64;
            this.btn_OduncAra.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(423, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Geri Verilen Tarih :";
            // 
            // dt_GeriVerilen
            // 
            this.dt_GeriVerilen.Location = new System.Drawing.Point(581, 152);
            this.dt_GeriVerilen.Name = "dt_GeriVerilen";
            this.dt_GeriVerilen.Size = new System.Drawing.Size(159, 20);
            this.dt_GeriVerilen.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "İade :";
            // 
            // OduncIadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 670);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_VerilmesiGereken);
            this.Controls.Add(this.dgv_IadeListesi);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_IadeEdilecekOdunc);
            this.Controls.Add(this.btn_OduncAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_GeriVerilen);
            this.Controls.Add(this.label1);
            this.Name = "OduncIadeForm";
            this.Text = "Ödünç İade";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IadeListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_VerilmesiGereken;
        private System.Windows.Forms.DataGridView dgv_IadeListesi;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_IadeEdilecekOdunc;
        private System.Windows.Forms.Button btn_OduncAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_GeriVerilen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}