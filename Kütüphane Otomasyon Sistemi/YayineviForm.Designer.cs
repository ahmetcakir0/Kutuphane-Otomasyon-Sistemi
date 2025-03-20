namespace Kutuphane_Otomasyon_Sistemi
{
    partial class YayineviForm
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
            this.txt_Yayinevi = new System.Windows.Forms.TextBox();
            this.txt_TelNo = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.dgv_YayıneviListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YayıneviListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Yayinevi
            // 
            this.txt_Yayinevi.Location = new System.Drawing.Point(452, 94);
            this.txt_Yayinevi.Name = "txt_Yayinevi";
            this.txt_Yayinevi.Size = new System.Drawing.Size(159, 20);
            this.txt_Yayinevi.TabIndex = 19;
            // 
            // txt_TelNo
            // 
            this.txt_TelNo.Location = new System.Drawing.Point(452, 157);
            this.txt_TelNo.Name = "txt_TelNo";
            this.txt_TelNo.Size = new System.Drawing.Size(159, 20);
            this.txt_TelNo.TabIndex = 20;
            this.txt_TelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TelNo_KeyPress);
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(834, 94);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(159, 20);
            this.txt_Eposta.TabIndex = 21;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(834, 157);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(159, 20);
            this.txt_Adres.TabIndex = 22;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(452, 256);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(118, 39);
            this.btn_Kaydet.TabIndex = 23;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // dgv_YayıneviListesi
            // 
            this.dgv_YayıneviListesi.AllowUserToAddRows = false;
            this.dgv_YayıneviListesi.AllowUserToDeleteRows = false;
            this.dgv_YayıneviListesi.AllowUserToResizeColumns = false;
            this.dgv_YayıneviListesi.AllowUserToResizeRows = false;
            this.dgv_YayıneviListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_YayıneviListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_YayıneviListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_YayıneviListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_YayıneviListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_YayıneviListesi.Location = new System.Drawing.Point(0, 447);
            this.dgv_YayıneviListesi.MultiSelect = false;
            this.dgv_YayıneviListesi.Name = "dgv_YayıneviListesi";
            this.dgv_YayıneviListesi.ReadOnly = true;
            this.dgv_YayıneviListesi.RowHeadersVisible = false;
            this.dgv_YayıneviListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_YayıneviListesi.Size = new System.Drawing.Size(1273, 254);
            this.dgv_YayıneviListesi.TabIndex = 25;
            this.dgv_YayıneviListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_YayıneviListesi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Yayınevi Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tel No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "E - posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Adres :";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(834, 256);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(118, 39);
            this.btn_Temizle.TabIndex = 30;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // YayineviForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 701);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_TelNo);
            this.Controls.Add(this.txt_Yayinevi);
            this.Controls.Add(this.dgv_YayıneviListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YayineviForm";
            this.Text = "Yayınevi";
            this.Load += new System.EventHandler(this.YayineviForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YayıneviListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Yayinevi;
        private System.Windows.Forms.TextBox txt_TelNo;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.DataGridView dgv_YayıneviListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Temizle;
    }
}