namespace Kütüphane_Otomasyon_Sistemi
{
    partial class KategoriRaflarForm
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
            this.txt_KategoriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dgv_KategoriRaflar = new System.Windows.Forms.DataGridView();
            this.btn_Temizleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KategoriRaflar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KategoriAdi
            // 
            this.txt_KategoriAdi.Location = new System.Drawing.Point(231, 95);
            this.txt_KategoriAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_KategoriAdi.Multiline = true;
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(206, 47);
            this.txt_KategoriAdi.TabIndex = 0;
            this.txt_KategoriAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KategoriAdi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(18, 254);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(148, 69);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(213, 255);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(148, 68);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dgv_KategoriRaflar
            // 
            this.dgv_KategoriRaflar.AllowUserToAddRows = false;
            this.dgv_KategoriRaflar.AllowUserToDeleteRows = false;
            this.dgv_KategoriRaflar.AllowUserToResizeColumns = false;
            this.dgv_KategoriRaflar.AllowUserToResizeRows = false;
            this.dgv_KategoriRaflar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KategoriRaflar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KategoriRaflar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KategoriRaflar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_KategoriRaflar.Location = new System.Drawing.Point(0, 400);
            this.dgv_KategoriRaflar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_KategoriRaflar.MultiSelect = false;
            this.dgv_KategoriRaflar.Name = "dgv_KategoriRaflar";
            this.dgv_KategoriRaflar.ReadOnly = true;
            this.dgv_KategoriRaflar.RowHeadersVisible = false;
            this.dgv_KategoriRaflar.RowHeadersWidth = 62;
            this.dgv_KategoriRaflar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KategoriRaflar.Size = new System.Drawing.Size(573, 325);
            this.dgv_KategoriRaflar.TabIndex = 55;
            this.dgv_KategoriRaflar.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_KategoriRaflar_ColumnHeaderMouseClick);
            this.dgv_KategoriRaflar.Click += new System.EventHandler(this.dgv_KategoriRaflar_Click);
            // 
            // btn_Temizleme
            // 
            this.btn_Temizleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizleme.Location = new System.Drawing.Point(406, 255);
            this.btn_Temizleme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Temizleme.Name = "btn_Temizleme";
            this.btn_Temizleme.Size = new System.Drawing.Size(148, 68);
            this.btn_Temizleme.TabIndex = 56;
            this.btn_Temizleme.Text = "TEMİZLE";
            this.btn_Temizleme.UseVisualStyleBackColor = true;
            this.btn_Temizleme.Click += new System.EventHandler(this.btn_Temizleme_Click);
            // 
            // KategoriRaflarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 725);
            this.Controls.Add(this.btn_Temizleme);
            this.Controls.Add(this.dgv_KategoriRaflar);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_KategoriAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "KategoriRaflarForm";
            this.Text = "Kategori - Raflar";
            this.Load += new System.EventHandler(this.KategoriRaflarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KategoriRaflar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KategoriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.DataGridView dgv_KategoriRaflar;
        private System.Windows.Forms.Button btn_Temizleme;
    }
}