using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankamatikSimilasyonu
{
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MN3O9G6\SQLEXPRESS;Initial Catalog=DbBankamatik;User ID=sa;Password=m10zxcvb");

        bool durum;

        void TekrarliKayitEngelleme()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select HesapNo,TC From TblKisiler Where HesapNo=@p1 or TC=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1","TR"+ mtxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", mtxtTcKimlikNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void btnHesapNoUret_Click(object sender, EventArgs e)
        {

            TekrarliKayitEngelleme();
            if (durum == true)
            {
                int sayi = rastgele.Next(100000, 1000000);
                mtxtHesapNo.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Bu Hesap Numarası ya da\nTC Kimlik Numarası Daha Önceden Alınmış\nLütfen Yeniden Deneyiniz", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Kişiler tablosuna ekleme yapıyoruz
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into TblKisiler (Ad,Soyad,TC,Telefon,HesapNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3",mtxtTcKimlikNo.Text);
            ekle.Parameters.AddWithValue("@p4", mtxtTelefon.Text);
            ekle.Parameters.AddWithValue("@p5","TR"+ mtxtHesapNo.Text);
            ekle.Parameters.AddWithValue("@p6", txtSifre.Text);
            ekle.ExecuteNonQuery();

            //Hesap tablosuna ekleme yapıyoruz
            SqlCommand ekleHesap = new SqlCommand("insert into TblHesap (HesapNo,Bakiye) values (@p1,@p2)", baglanti);
            ekleHesap.Parameters.AddWithValue("@p1", "TR" + mtxtHesapNo.Text);
            ekleHesap.Parameters.AddWithValue("@p2", "100");
            ekleHesap.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bankamıza Başarılı Bir Şekilde Kaydınız Oluşturulmuştur.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtAd.Clear();
            txtSifre.Clear();
            txtSoyad.Clear();
            mtxtHesapNo.Clear();
            mtxtTcKimlikNo.Clear();
            mtxtTelefon.Clear();
            txtAd.Focus();
        }

    }
}
