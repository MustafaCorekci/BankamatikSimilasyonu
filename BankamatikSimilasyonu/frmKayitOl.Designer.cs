namespace BankamatikSimilasyonu
{
    partial class frmKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayitOl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mtxtTcKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.btnHesapNoUret = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad             :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hesap No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre           :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(131, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(176, 36);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(130, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(176, 36);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(130, 225);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(176, 36);
            this.txtSifre.TabIndex = 5;
            // 
            // mtxtTcKimlikNo
            // 
            this.mtxtTcKimlikNo.Location = new System.Drawing.Point(131, 105);
            this.mtxtTcKimlikNo.Mask = "00000000000";
            this.mtxtTcKimlikNo.Name = "mtxtTcKimlikNo";
            this.mtxtTcKimlikNo.Size = new System.Drawing.Size(175, 36);
            this.mtxtTcKimlikNo.TabIndex = 2;
            this.mtxtTcKimlikNo.ValidatingType = typeof(int);
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(130, 143);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(175, 36);
            this.mtxtTelefon.TabIndex = 3;
            // 
            // mtxtHesapNo
            // 
            this.mtxtHesapNo.Enabled = false;
            this.mtxtHesapNo.Location = new System.Drawing.Point(131, 185);
            this.mtxtHesapNo.Mask = "000000";
            this.mtxtHesapNo.Name = "mtxtHesapNo";
            this.mtxtHesapNo.Size = new System.Drawing.Size(175, 36);
            this.mtxtHesapNo.TabIndex = 11;
            this.mtxtHesapNo.ValidatingType = typeof(int);
            // 
            // btnHesapNoUret
            // 
            this.btnHesapNoUret.Location = new System.Drawing.Point(312, 185);
            this.btnHesapNoUret.Name = "btnHesapNoUret";
            this.btnHesapNoUret.Size = new System.Drawing.Size(94, 30);
            this.btnHesapNoUret.TabIndex = 4;
            this.btnHesapNoUret.Text = "...";
            this.btnHesapNoUret.UseVisualStyleBackColor = true;
            this.btnHesapNoUret.Click += new System.EventHandler(this.btnHesapNoUret_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(130, 274);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(175, 48);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "KAYIT  OL ";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(313, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 145);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lütfen\r\nButona\r\nÇift\r\nTıklayınız\r\n! ! !\r\n";
            // 
            // frmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(410, 340);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnHesapNoUret);
            this.Controls.Add(this.mtxtHesapNo);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.mtxtTcKimlikNo);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT  OL ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mtxtTcKimlikNo;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.MaskedTextBox mtxtHesapNo;
        private System.Windows.Forms.Button btnHesapNoUret;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label label7;
    }
}