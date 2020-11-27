using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankamatikSimilasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MN3O9G6\SQLEXPRESS;Initial Catalog=DbBankamatik;User ID=sa;Password=m10zxcvb");

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl fr = new frmKayitOl();
            fr.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblKisiler Where HesapNo=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mtxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmIslemler fr = new frmIslemler();
                fr.hesap = mtxtHesapNo.Text;
                this.Hide();
                fr.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hesap Numarası Ya Da Şifre Hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
