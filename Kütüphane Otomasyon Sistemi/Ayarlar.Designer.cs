namespace Kutuphane_Otomasyon_Sistemi
{
    partial class Ayarlar
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
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.txt_OduncSuresi = new System.Windows.Forms.TextBox();
            this.txt_CezaUcreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_YeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(175, 27);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(159, 20);
            this.txt_KullaniciAdi.TabIndex = 53;
            this.txt_KullaniciAdi.TextChanged += new System.EventHandler(this.txt_KullaniciAdi_TextChanged);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_Sifre.Location = new System.Drawing.Point(175, 65);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(159, 20);
            this.txt_Sifre.TabIndex = 54;
            this.txt_Sifre.TextChanged += new System.EventHandler(this.txt_Sifre_TextChanged);
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_YeniSifre.Enabled = false;
            this.txt_YeniSifre.Location = new System.Drawing.Point(175, 104);
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.PasswordChar = '*';
            this.txt_YeniSifre.Size = new System.Drawing.Size(159, 20);
            this.txt_YeniSifre.TabIndex = 55;
            // 
            // txt_OduncSuresi
            // 
            this.txt_OduncSuresi.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_OduncSuresi.Enabled = false;
            this.txt_OduncSuresi.Location = new System.Drawing.Point(175, 185);
            this.txt_OduncSuresi.Name = "txt_OduncSuresi";
            this.txt_OduncSuresi.Size = new System.Drawing.Size(159, 20);
            this.txt_OduncSuresi.TabIndex = 56;
            // 
            // txt_CezaUcreti
            // 
            this.txt_CezaUcreti.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_CezaUcreti.Enabled = false;
            this.txt_CezaUcreti.Location = new System.Drawing.Point(175, 227);
            this.txt_CezaUcreti.Name = "txt_CezaUcreti";
            this.txt_CezaUcreti.Size = new System.Drawing.Size(159, 20);
            this.txt_CezaUcreti.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Kullanıcı adınızı giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(56, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Şifrenizi giriniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(56, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Yeni şifrenizi giriniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(56, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Ödünç Alma Süresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(56, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Günlük ceza ücreti :";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(73, 287);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(96, 30);
            this.btn_Kaydet.TabIndex = 64;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(56, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Yeni şifrenizi giriniz :";
            // 
            // txt_YeniSifreTekrar
            // 
            this.txt_YeniSifreTekrar.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_YeniSifreTekrar.Enabled = false;
            this.txt_YeniSifreTekrar.Location = new System.Drawing.Point(175, 144);
            this.txt_YeniSifreTekrar.Name = "txt_YeniSifreTekrar";
            this.txt_YeniSifreTekrar.PasswordChar = '*';
            this.txt_YeniSifreTekrar.Size = new System.Drawing.Size(159, 20);
            this.txt_YeniSifreTekrar.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(215, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 69;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(385, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_YeniSifreTekrar);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CezaUcreti);
            this.Controls.Add(this.txt_OduncSuresi);
            this.Controls.Add(this.txt_YeniSifre);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.TextBox txt_OduncSuresi;
        private System.Windows.Forms.TextBox txt_CezaUcreti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_YeniSifreTekrar;
        private System.Windows.Forms.Button button2;
    }
}