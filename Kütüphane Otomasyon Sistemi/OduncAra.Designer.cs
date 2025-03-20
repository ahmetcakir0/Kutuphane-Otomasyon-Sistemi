namespace Kutuphane_Otomasyon_Sistemi
{
    partial class OduncAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncAra));
            this.dgv_OduncListesi = new System.Windows.Forms.DataGridView();
            this.btn_OduncAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_OduncAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_OduncListesi.Location = new System.Drawing.Point(0, 53);
            this.dgv_OduncListesi.MultiSelect = false;
            this.dgv_OduncListesi.Name = "dgv_OduncListesi";
            this.dgv_OduncListesi.ReadOnly = true;
            this.dgv_OduncListesi.RowHeadersVisible = false;
            this.dgv_OduncListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OduncListesi.Size = new System.Drawing.Size(293, 397);
            this.dgv_OduncListesi.TabIndex = 8;
            // 
            // btn_OduncAra
            // 
            this.btn_OduncAra.ImageKey = "mercek.png";
            this.btn_OduncAra.ImageList = this.ımageList1;
            this.btn_OduncAra.Location = new System.Drawing.Point(225, 12);
            this.btn_OduncAra.Name = "btn_OduncAra";
            this.btn_OduncAra.Size = new System.Drawing.Size(44, 23);
            this.btn_OduncAra.TabIndex = 7;
            this.btn_OduncAra.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mercek.png");
            // 
            // txt_OduncAra
            // 
            this.txt_OduncAra.Location = new System.Drawing.Point(32, 12);
            this.txt_OduncAra.Name = "txt_OduncAra";
            this.txt_OduncAra.Size = new System.Drawing.Size(187, 20);
            this.txt_OduncAra.TabIndex = 6;
            // 
            // OduncAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.dgv_OduncListesi);
            this.Controls.Add(this.btn_OduncAra);
            this.Controls.Add(this.txt_OduncAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OduncAra";
            this.Text = "Ödünç Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OduncListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_OduncListesi;
        private System.Windows.Forms.Button btn_OduncAra;
        private System.Windows.Forms.TextBox txt_OduncAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}