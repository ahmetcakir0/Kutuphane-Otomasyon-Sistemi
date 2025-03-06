namespace Kütüphane_Otomasyon_Sistemi
{
    partial class YazarAraPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarAraPopupForm));
            this.dgv_YazarListesi = new System.Windows.Forms.DataGridView();
            this.btn_YazarAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_YazarAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YazarListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_YazarListesi
            // 
            this.dgv_YazarListesi.AllowUserToAddRows = false;
            this.dgv_YazarListesi.AllowUserToDeleteRows = false;
            this.dgv_YazarListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_YazarListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_YazarListesi.Location = new System.Drawing.Point(0, 50);
            this.dgv_YazarListesi.Name = "dgv_YazarListesi";
            this.dgv_YazarListesi.ReadOnly = true;
            this.dgv_YazarListesi.Size = new System.Drawing.Size(267, 397);
            this.dgv_YazarListesi.TabIndex = 8;
            // 
            // btn_YazarAra
            // 
            this.btn_YazarAra.ImageKey = "mercek.png";
            this.btn_YazarAra.ImageList = this.ımageList1;
            this.btn_YazarAra.Location = new System.Drawing.Point(205, 12);
            this.btn_YazarAra.Name = "btn_YazarAra";
            this.btn_YazarAra.Size = new System.Drawing.Size(44, 23);
            this.btn_YazarAra.TabIndex = 7;
            this.btn_YazarAra.UseVisualStyleBackColor = true;
            this.btn_YazarAra.Click += new System.EventHandler(this.btn_YazarAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // txt_YazarAra
            // 
            this.txt_YazarAra.Location = new System.Drawing.Point(12, 12);
            this.txt_YazarAra.Name = "txt_YazarAra";
            this.txt_YazarAra.Size = new System.Drawing.Size(187, 20);
            this.txt_YazarAra.TabIndex = 6;
            // 
            // YazarAraPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 447);
            this.Controls.Add(this.dgv_YazarListesi);
            this.Controls.Add(this.btn_YazarAra);
            this.Controls.Add(this.txt_YazarAra);
            this.Name = "YazarAraPopupForm";
            this.Text = "Yazar Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YazarListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_YazarListesi;
        private System.Windows.Forms.Button btn_YazarAra;
        private System.Windows.Forms.TextBox txt_YazarAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}