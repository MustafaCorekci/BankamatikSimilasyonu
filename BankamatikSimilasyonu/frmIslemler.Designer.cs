namespace BankamatikSimilasyonu
{
    partial class frmIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIslemler));
            this.btnParaCekme = new System.Windows.Forms.Button();
            this.btnParaYatirma = new System.Windows.Forms.Button();
            this.grpIslem = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnIslemGecmisi = new System.Windows.Forms.Button();
            this.btnHavaleIslemleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.grpHavale = new System.Windows.Forms.GroupBox();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.txtHavaleTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpYatirma = new System.Windows.Forms.GroupBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.txtYatirTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpCekme = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.txtCekmeTutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblToplaTutar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpIslem.SuspendLayout();
            this.grpHavale.SuspendLayout();
            this.grpYatirma.SuspendLayout();
            this.grpCekme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParaCekme
            // 
            this.btnParaCekme.ForeColor = System.Drawing.Color.Black;
            this.btnParaCekme.Location = new System.Drawing.Point(170, 39);
            this.btnParaCekme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(146, 52);
            this.btnParaCekme.TabIndex = 2;
            this.btnParaCekme.Text = "Para Çekme";
            this.btnParaCekme.UseVisualStyleBackColor = true;
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // btnParaYatirma
            // 
            this.btnParaYatirma.ForeColor = System.Drawing.Color.Black;
            this.btnParaYatirma.Location = new System.Drawing.Point(16, 39);
            this.btnParaYatirma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParaYatirma.Name = "btnParaYatirma";
            this.btnParaYatirma.Size = new System.Drawing.Size(146, 52);
            this.btnParaYatirma.TabIndex = 1;
            this.btnParaYatirma.Text = "Para Yatırma";
            this.btnParaYatirma.UseVisualStyleBackColor = true;
            this.btnParaYatirma.Click += new System.EventHandler(this.btnParaYatirma_Click);
            // 
            // grpIslem
            // 
            this.grpIslem.Controls.Add(this.btnCikis);
            this.grpIslem.Controls.Add(this.btnIslemGecmisi);
            this.grpIslem.Controls.Add(this.btnHavaleIslemleri);
            this.grpIslem.Controls.Add(this.btnParaYatirma);
            this.grpIslem.Controls.Add(this.btnParaCekme);
            this.grpIslem.ForeColor = System.Drawing.Color.Red;
            this.grpIslem.Location = new System.Drawing.Point(12, 214);
            this.grpIslem.Name = "grpIslem";
            this.grpIslem.Size = new System.Drawing.Size(330, 239);
            this.grpIslem.TabIndex = 3;
            this.grpIslem.TabStop = false;
            this.grpIslem.Text = "İŞLEMLER";
            // 
            // btnCikis
            // 
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(55, 174);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(220, 52);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnIslemGecmisi
            // 
            this.btnIslemGecmisi.ForeColor = System.Drawing.Color.Black;
            this.btnIslemGecmisi.Location = new System.Drawing.Point(170, 111);
            this.btnIslemGecmisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIslemGecmisi.Name = "btnIslemGecmisi";
            this.btnIslemGecmisi.Size = new System.Drawing.Size(146, 52);
            this.btnIslemGecmisi.TabIndex = 4;
            this.btnIslemGecmisi.Text = "İşlem Geçmişi";
            this.btnIslemGecmisi.UseVisualStyleBackColor = true;
            this.btnIslemGecmisi.Click += new System.EventHandler(this.btnIslemGecmisi_Click);
            // 
            // btnHavaleIslemleri
            // 
            this.btnHavaleIslemleri.ForeColor = System.Drawing.Color.Black;
            this.btnHavaleIslemleri.Location = new System.Drawing.Point(16, 111);
            this.btnHavaleIslemleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHavaleIslemleri.Name = "btnHavaleIslemleri";
            this.btnHavaleIslemleri.Size = new System.Drawing.Size(146, 52);
            this.btnHavaleIslemleri.TabIndex = 3;
            this.btnHavaleIslemleri.Text = "Havale İşlemleri";
            this.btnHavaleIslemleri.UseVisualStyleBackColor = true;
            this.btnHavaleIslemleri.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesap No : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC Kimlik No : ";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(126, 64);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(35, 20);
            this.lblAdSoyad.TabIndex = 8;
            this.lblAdSoyad.Text = "Null";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(126, 164);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(35, 20);
            this.lblTcNo.TabIndex = 9;
            this.lblTcNo.Text = "Null";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(126, 131);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(35, 20);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Null";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(126, 96);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(35, 20);
            this.lblHesapNo.TabIndex = 11;
            this.lblHesapNo.Text = "Null";
            // 
            // grpHavale
            // 
            this.grpHavale.Controls.Add(this.btnHavaleYap);
            this.grpHavale.Controls.Add(this.txtHavaleTutar);
            this.grpHavale.Controls.Add(this.label6);
            this.grpHavale.Controls.Add(this.mtxtHesapNo);
            this.grpHavale.Controls.Add(this.label5);
            this.grpHavale.ForeColor = System.Drawing.Color.Red;
            this.grpHavale.Location = new System.Drawing.Point(28, 483);
            this.grpHavale.Name = "grpHavale";
            this.grpHavale.Size = new System.Drawing.Size(279, 196);
            this.grpHavale.TabIndex = 12;
            this.grpHavale.TabStop = false;
            this.grpHavale.Text = "HAVALE İŞLEMLERİ";
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.ForeColor = System.Drawing.Color.Black;
            this.btnHavaleYap.Location = new System.Drawing.Point(19, 131);
            this.btnHavaleYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(239, 43);
            this.btnHavaleYap.TabIndex = 2;
            this.btnHavaleYap.Text = "HAVALE YAP";
            this.btnHavaleYap.UseVisualStyleBackColor = true;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // txtHavaleTutar
            // 
            this.txtHavaleTutar.Location = new System.Drawing.Point(110, 87);
            this.txtHavaleTutar.Name = "txtHavaleTutar";
            this.txtHavaleTutar.Size = new System.Drawing.Size(148, 26);
            this.txtHavaleTutar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tutar : ";
            // 
            // mtxtHesapNo
            // 
            this.mtxtHesapNo.Location = new System.Drawing.Point(110, 46);
            this.mtxtHesapNo.Mask = "TR000000";
            this.mtxtHesapNo.Name = "mtxtHesapNo";
            this.mtxtHesapNo.Size = new System.Drawing.Size(148, 26);
            this.mtxtHesapNo.TabIndex = 0;
            this.mtxtHesapNo.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hesap No :";
            // 
            // grpYatirma
            // 
            this.grpYatirma.Controls.Add(this.btnParaYatir);
            this.grpYatirma.Controls.Add(this.txtYatirTutar);
            this.grpYatirma.Controls.Add(this.label7);
            this.grpYatirma.ForeColor = System.Drawing.Color.Red;
            this.grpYatirma.Location = new System.Drawing.Point(29, 505);
            this.grpYatirma.Name = "grpYatirma";
            this.grpYatirma.Size = new System.Drawing.Size(279, 159);
            this.grpYatirma.TabIndex = 13;
            this.grpYatirma.TabStop = false;
            this.grpYatirma.Text = "PARA YATİRMA İŞLEMLER";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.ForeColor = System.Drawing.Color.Black;
            this.btnParaYatir.Location = new System.Drawing.Point(10, 89);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(251, 43);
            this.btnParaYatir.TabIndex = 1;
            this.btnParaYatir.Text = "YATIR";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // txtYatirTutar
            // 
            this.txtYatirTutar.Location = new System.Drawing.Point(154, 46);
            this.txtYatirTutar.Name = "txtYatirTutar";
            this.txtYatirTutar.Size = new System.Drawing.Size(110, 26);
            this.txtYatirTutar.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Yatıracağınız Tutar : ";
            // 
            // grpCekme
            // 
            this.grpCekme.Controls.Add(this.btnParaCek);
            this.grpCekme.Controls.Add(this.txtCekmeTutar);
            this.grpCekme.Controls.Add(this.label8);
            this.grpCekme.ForeColor = System.Drawing.Color.Red;
            this.grpCekme.Location = new System.Drawing.Point(28, 505);
            this.grpCekme.Name = "grpCekme";
            this.grpCekme.Size = new System.Drawing.Size(279, 159);
            this.grpCekme.TabIndex = 14;
            this.grpCekme.TabStop = false;
            this.grpCekme.Text = "PARA ÇEKME İŞLEMLERİ";
            // 
            // btnParaCek
            // 
            this.btnParaCek.ForeColor = System.Drawing.Color.Black;
            this.btnParaCek.Location = new System.Drawing.Point(10, 89);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(254, 43);
            this.btnParaCek.TabIndex = 1;
            this.btnParaCek.Text = "ÇEK";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // txtCekmeTutar
            // 
            this.txtCekmeTutar.Location = new System.Drawing.Point(154, 46);
            this.txtCekmeTutar.Name = "txtCekmeTutar";
            this.txtCekmeTutar.Size = new System.Drawing.Size(110, 26);
            this.txtCekmeTutar.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Çekiceğiniz Tutar : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(154, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(416, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "BİLO BANKA HOŞGELDİNİZ";
            // 
            // lblToplaTutar
            // 
            this.lblToplaTutar.AutoSize = true;
            this.lblToplaTutar.Location = new System.Drawing.Point(576, 707);
            this.lblToplaTutar.Name = "lblToplaTutar";
            this.lblToplaTutar.Size = new System.Drawing.Size(35, 20);
            this.lblToplaTutar.TabIndex = 18;
            this.lblToplaTutar.Text = "Null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 707);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Toplam Tutarınız : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(659, 707);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "TL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(388, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // frmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(700, 736);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblToplaTutar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpCekme);
            this.Controls.Add(this.grpYatirma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpHavale);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpIslem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKER BİLO BANKA HOŞGELDİNİZ";
            this.Load += new System.EventHandler(this.frmIslemler_Load);
            this.grpIslem.ResumeLayout(false);
            this.grpHavale.ResumeLayout(false);
            this.grpHavale.PerformLayout();
            this.grpYatirma.ResumeLayout(false);
            this.grpYatirma.PerformLayout();
            this.grpCekme.ResumeLayout(false);
            this.grpCekme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParaCekme;
        private System.Windows.Forms.Button btnParaYatirma;
        private System.Windows.Forms.GroupBox grpIslem;
        private System.Windows.Forms.Button btnIslemGecmisi;
        private System.Windows.Forms.Button btnHavaleIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.GroupBox grpHavale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHavaleYap;
        private System.Windows.Forms.TextBox txtHavaleTutar;
        private System.Windows.Forms.GroupBox grpYatirma;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.TextBox txtYatirTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpCekme;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.TextBox txtCekmeTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblToplaTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}