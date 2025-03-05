namespace Kutuphane_Otomasyon_Sistemi
{
    partial class TurlerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TurEkle = new System.Windows.Forms.TextBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_TurListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TurListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür Ekle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varsa açıklama ekleyiniz :";
            // 
            // txt_TurEkle
            // 
            this.txt_TurEkle.Location = new System.Drawing.Point(565, 83);
            this.txt_TurEkle.Name = "txt_TurEkle";
            this.txt_TurEkle.Size = new System.Drawing.Size(159, 20);
            this.txt_TurEkle.TabIndex = 20;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(565, 142);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(159, 80);
            this.txt_Aciklama.TabIndex = 21;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(392, 253);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 36;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click_1);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(601, 253);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(118, 39);
            this.btn_Temizle.TabIndex = 38;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_TurListesi
            // 
            this.dgv_TurListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TurListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_TurListesi.Location = new System.Drawing.Point(0, 343);
            this.dgv_TurListesi.Name = "dgv_TurListesi";
            this.dgv_TurListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TurListesi.Size = new System.Drawing.Size(1074, 348);
            this.dgv_TurListesi.TabIndex = 39;
            this.dgv_TurListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TurListesi_CellContentClick_1);
            // 
            // TurlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 691);
            this.Controls.Add(this.dgv_TurListesi);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.txt_TurEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TurlerForm";
            this.Text = "Türler";
            this.Load += new System.EventHandler(this.TurlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TurListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TurEkle;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_TurListesi;
    }
}