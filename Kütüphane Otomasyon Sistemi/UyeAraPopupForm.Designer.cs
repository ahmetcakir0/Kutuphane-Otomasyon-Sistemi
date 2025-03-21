namespace Kütuphane_Otomasyon_Sistemi
{
    partial class UyeAraPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeAraPopupForm));
            this.txt_KisiAra = new System.Windows.Forms.TextBox();
            this.btn_KisiAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgv_KisilerListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KisilerListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KisiAra
            // 
            this.txt_KisiAra.Location = new System.Drawing.Point(18, 18);
            this.txt_KisiAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_KisiAra.Name = "txt_KisiAra";
            this.txt_KisiAra.Size = new System.Drawing.Size(278, 26);
            this.txt_KisiAra.TabIndex = 0;
            // 
            // btn_KisiAra
            // 
            this.btn_KisiAra.ImageKey = "mercek.png";
            this.btn_KisiAra.ImageList = this.ımageList1;
            this.btn_KisiAra.Location = new System.Drawing.Point(308, 18);
            this.btn_KisiAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_KisiAra.Name = "btn_KisiAra";
            this.btn_KisiAra.Size = new System.Drawing.Size(66, 35);
            this.btn_KisiAra.TabIndex = 1;
            this.btn_KisiAra.UseVisualStyleBackColor = true;
            this.btn_KisiAra.Click += new System.EventHandler(this.btn_KisiAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // dgv_KisilerListesi
            // 
            this.dgv_KisilerListesi.AllowUserToAddRows = false;
            this.dgv_KisilerListesi.AllowUserToDeleteRows = false;
            this.dgv_KisilerListesi.AllowUserToResizeColumns = false;
            this.dgv_KisilerListesi.AllowUserToResizeRows = false;
            this.dgv_KisilerListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KisilerListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KisilerListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KisilerListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_KisilerListesi.Location = new System.Drawing.Point(0, 81);
            this.dgv_KisilerListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_KisilerListesi.MultiSelect = false;
            this.dgv_KisilerListesi.Name = "dgv_KisilerListesi";
            this.dgv_KisilerListesi.ReadOnly = true;
            this.dgv_KisilerListesi.RowHeadersVisible = false;
            this.dgv_KisilerListesi.RowHeadersWidth = 62;
            this.dgv_KisilerListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KisilerListesi.Size = new System.Drawing.Size(392, 611);
            this.dgv_KisilerListesi.TabIndex = 2;
            this.dgv_KisilerListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KisilerListesi_CellContentClick);
            this.dgv_KisilerListesi.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_KisilerListesi_ColumnHeaderMouseClick);
            this.dgv_KisilerListesi.DoubleClick += new System.EventHandler(this.dgv_KisilerListesi_DoubleClick);
            // 
            // UyeAraPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 692);
            this.Controls.Add(this.dgv_KisilerListesi);
            this.Controls.Add(this.btn_KisiAra);
            this.Controls.Add(this.txt_KisiAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UyeAraPopupForm";
            this.Text = "Üye Ara";
            this.Load += new System.EventHandler(this.UyeAraPopupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KisilerListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KisiAra;
        private System.Windows.Forms.Button btn_KisiAra;
        private System.Windows.Forms.DataGridView dgv_KisilerListesi;
        private System.Windows.Forms.ImageList ımageList1;
    }
}