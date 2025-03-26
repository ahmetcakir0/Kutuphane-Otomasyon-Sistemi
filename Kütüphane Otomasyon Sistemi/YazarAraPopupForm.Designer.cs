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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_YazarListesi.AllowUserToResizeColumns = false;
            this.dgv_YazarListesi.AllowUserToResizeRows = false;
            this.dgv_YazarListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_YazarListesi.BackgroundColor = System.Drawing.Color.Brown;
            this.dgv_YazarListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_YazarListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_YazarListesi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_YazarListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_YazarListesi.Location = new System.Drawing.Point(0, 50);
            this.dgv_YazarListesi.MultiSelect = false;
            this.dgv_YazarListesi.Name = "dgv_YazarListesi";
            this.dgv_YazarListesi.ReadOnly = true;
            this.dgv_YazarListesi.RowHeadersVisible = false;
            this.dgv_YazarListesi.RowHeadersWidth = 62;
            this.dgv_YazarListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_YazarListesi.Size = new System.Drawing.Size(267, 397);
            this.dgv_YazarListesi.TabIndex = 8;
            this.dgv_YazarListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_YazarListesi_CellContentClick);
            this.dgv_YazarListesi.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_YazarListesi_ColumnHeaderMouseClick);
            this.dgv_YazarListesi.DoubleClick += new System.EventHandler(this.YazarAraPopupForm_DoubleClick);
            // 
            // btn_YazarAra
            // 
            this.btn_YazarAra.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_YazarAra.ImageKey = "mercek.png";
            this.btn_YazarAra.ImageList = this.ımageList1;
            this.btn_YazarAra.Location = new System.Drawing.Point(205, 12);
            this.btn_YazarAra.Name = "btn_YazarAra";
            this.btn_YazarAra.Size = new System.Drawing.Size(44, 23);
            this.btn_YazarAra.TabIndex = 7;
            this.btn_YazarAra.UseVisualStyleBackColor = false;
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
            this.txt_YazarAra.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_YazarAra.Location = new System.Drawing.Point(12, 12);
            this.txt_YazarAra.Name = "txt_YazarAra";
            this.txt_YazarAra.Size = new System.Drawing.Size(187, 20);
            this.txt_YazarAra.TabIndex = 6;
            // 
            // YazarAraPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(267, 447);
            this.Controls.Add(this.dgv_YazarListesi);
            this.Controls.Add(this.btn_YazarAra);
            this.Controls.Add(this.txt_YazarAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YazarAraPopupForm";
            this.Text = "Yazar Ara";
            this.Load += new System.EventHandler(this.YazarAraPopupForm_Load);
            this.DoubleClick += new System.EventHandler(this.YazarAraPopupForm_DoubleClick);
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