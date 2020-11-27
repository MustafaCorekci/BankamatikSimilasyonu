namespace BankamatikSimilasyonu
{
    partial class frmHareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHareketler));
            this.grpIslemGecmisi = new System.Windows.Forms.GroupBox();
            this.dgvHavale = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvYatirma = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCekme = new System.Windows.Forms.DataGridView();
            this.grpIslemGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHavale)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYatirma)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekme)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIslemGecmisi
            // 
            this.grpIslemGecmisi.Controls.Add(this.dgvHavale);
            this.grpIslemGecmisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIslemGecmisi.ForeColor = System.Drawing.Color.Blue;
            this.grpIslemGecmisi.Location = new System.Drawing.Point(12, 4);
            this.grpIslemGecmisi.Name = "grpIslemGecmisi";
            this.grpIslemGecmisi.Size = new System.Drawing.Size(600, 259);
            this.grpIslemGecmisi.TabIndex = 16;
            this.grpIslemGecmisi.TabStop = false;
            this.grpIslemGecmisi.Text = "HAVALE  GEÇMİŞLERİM";
            // 
            // dgvHavale
            // 
            this.dgvHavale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHavale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHavale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHavale.Location = new System.Drawing.Point(3, 22);
            this.dgvHavale.Name = "dgvHavale";
            this.dgvHavale.Size = new System.Drawing.Size(594, 234);
            this.dgvHavale.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvYatirma);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 259);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YATIRMA GEÇMİŞLERİM";
            // 
            // dgvYatirma
            // 
            this.dgvYatirma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYatirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYatirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYatirma.Location = new System.Drawing.Point(3, 22);
            this.dgvYatirma.Name = "dgvYatirma";
            this.dgvYatirma.Size = new System.Drawing.Size(594, 234);
            this.dgvYatirma.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCekme);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 259);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÇEKME  GEÇMİŞLERİM";
            // 
            // dgvCekme
            // 
            this.dgvCekme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCekme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCekme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCekme.Location = new System.Drawing.Point(3, 22);
            this.dgvCekme.Name = "dgvCekme";
            this.dgvCekme.Size = new System.Drawing.Size(594, 234);
            this.dgvCekme.TabIndex = 0;
            // 
            // frmHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(626, 807);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpIslemGecmisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHareketler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEÇMİŞ İŞLEMLERİ GÖRÜNTÜLE";
            this.Load += new System.EventHandler(this.frmHareketler_Load);
            this.grpIslemGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHavale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYatirma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIslemGecmisi;
        private System.Windows.Forms.DataGridView dgvHavale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvYatirma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCekme;
    }
}