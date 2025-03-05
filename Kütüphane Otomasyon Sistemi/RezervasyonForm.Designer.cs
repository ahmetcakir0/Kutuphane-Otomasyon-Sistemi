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
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.dgv_Rezervasyon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_RezervasyonUye
            // 
            this.txt_RezervasyonUye.Location = new System.Drawing.Point(102, 55);
            this.txt_RezervasyonUye.Name = "txt_RezervasyonUye";
            this.txt_RezervasyonUye.Size = new System.Drawing.Size(159, 20);
            this.txt_RezervasyonUye.TabIndex = 52;
            // 
            // btn_UyeAra
            // 
            this.btn_UyeAra.ImageKey = "mercek.png";
            this.btn_UyeAra.ImageList = this.ımageList1;
            this.btn_UyeAra.Location = new System.Drawing.Point(267, 53);
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
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Üye :";
            // 
            // txt_RezervasyonKitap
            // 
            this.txt_RezervasyonKitap.Location = new System.Drawing.Point(422, 56);
            this.txt_RezervasyonKitap.Name = "txt_RezervasyonKitap";
            this.txt_RezervasyonKitap.Size = new System.Drawing.Size(159, 20);
            this.txt_RezervasyonKitap.TabIndex = 55;
            // 
            // btn_KitapAra
            // 
            this.btn_KitapAra.ImageKey = "mercek.png";
            this.btn_KitapAra.ImageList = this.ımageList1;
            this.btn_KitapAra.Location = new System.Drawing.Point(587, 52);
            this.btn_KitapAra.Name = "btn_KitapAra";
            this.btn_KitapAra.Size = new System.Drawing.Size(61, 23);
            this.btn_KitapAra.TabIndex = 54;
            this.btn_KitapAra.UseVisualStyleBackColor = true;
            this.btn_KitapAra.Click += new System.EventHandler(this.btn_KitapAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Kitap :";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(504, 127);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(118, 39);
            this.btn_Guncelle.TabIndex = 58;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(331, 127);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(118, 39);
            this.btn_Sil.TabIndex = 57;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.Location = new System.Drawing.Point(154, 127);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(118, 39);
            this.btn.TabIndex = 56;
            this.btn.Text = "KAYDET";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // dgv_Rezervasyon
            // 
            this.dgv_Rezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rezervasyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Rezervasyon.Location = new System.Drawing.Point(0, 204);
            this.dgv_Rezervasyon.Name = "dgv_Rezervasyon";
            this.dgv_Rezervasyon.ReadOnly = true;
            this.dgv_Rezervasyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Rezervasyon.Size = new System.Drawing.Size(800, 246);
            this.dgv_Rezervasyon.TabIndex = 59;
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Rezervasyon);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt_RezervasyonKitap);
            this.Controls.Add(this.btn_KitapAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RezervasyonUye);
            this.Controls.Add(this.btn_UyeAra);
            this.Controls.Add(this.label2);
            this.Name = "RezervasyonForm";
            this.Text = "Rezervasyon";
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
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgv_Rezervasyon;
        private System.Windows.Forms.ImageList ımageList1;
    }
}