namespace Kutuphane_Otomasyon_Sistemi
{
    partial class KitapAraPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapAraPopupForm));
            this.dgv_KitapListesi = new System.Windows.Forms.DataGridView();
            this.btn_KisiAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_KitapAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KitapListesi
            // 
            this.dgv_KitapListesi.AllowUserToAddRows = false;
            this.dgv_KitapListesi.AllowUserToDeleteRows = false;
            this.dgv_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KitapListesi.Location = new System.Drawing.Point(12, 41);
            this.dgv_KitapListesi.Name = "dgv_KitapListesi";
            this.dgv_KitapListesi.ReadOnly = true;
            this.dgv_KitapListesi.Size = new System.Drawing.Size(240, 397);
            this.dgv_KitapListesi.TabIndex = 5;
            // 
            // btn_KisiAra
            // 
            this.btn_KisiAra.ImageKey = "mercek.png";
            this.btn_KisiAra.ImageList = this.ımageList1;
            this.btn_KisiAra.Location = new System.Drawing.Point(205, 12);
            this.btn_KisiAra.Name = "btn_KisiAra";
            this.btn_KisiAra.Size = new System.Drawing.Size(44, 23);
            this.btn_KisiAra.TabIndex = 4;
            this.btn_KisiAra.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // txt_KitapAra
            // 
            this.txt_KitapAra.Location = new System.Drawing.Point(12, 12);
            this.txt_KitapAra.Name = "txt_KitapAra";
            this.txt_KitapAra.Size = new System.Drawing.Size(187, 20);
            this.txt_KitapAra.TabIndex = 3;
            // 
            // KitapAraPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.dgv_KitapListesi);
            this.Controls.Add(this.btn_KisiAra);
            this.Controls.Add(this.txt_KitapAra);
            this.MaximizeBox = false;
            this.Name = "KitapAraPopupForm";
            this.Text = "Kitap Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KitapListesi;
        private System.Windows.Forms.Button btn_KisiAra;
        private System.Windows.Forms.TextBox txt_KitapAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}