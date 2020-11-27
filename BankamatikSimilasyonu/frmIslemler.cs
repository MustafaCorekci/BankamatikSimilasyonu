using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankamatikSimilasyonu
{
    public partial class frmIslemler : Form
    {
        public frmIslemler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MN3O9G6\SQLEXPRESS;Initial Catalog=DbBankamatik;User ID=sa;Password=m10zxcvb");

        public string hesap; decimal kasa = 0;
        
        //İşlem seçildiğinde yapılacak işlemin alanını aktif yapıyor
        private void btnHavale_Click(object sender, EventArgs e)
        {
            grpHavale.Visible = true;
            grpCekme.Visible = false;
            grpYatirma.Visible = false;
            txtHavaleTutar.Focus();
        }
        private void btnParaYatirma_Click(object sender, EventArgs e)
        {
            grpYatirma.Visible = true;
            grpHavale.Visible = false;
            grpCekme.Visible = false;
            txtYatirTutar.Focus();
        }
        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            grpCekme.Visible = true;
            grpHavale.Visible = false;
            grpYatirma.Visible = false;
            txtCekmeTutar.Focus();
        }
        
        //Form yüklendiğinde işlemler sayfamıza kişi bilgilerini çekiyoruz.
        private void frmIslemler_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;
            baglanti.Open();
            SqlCommand bilgi = new SqlCommand("Select * From TblKisiler Where HesapNo=@p1", baglanti);
            bilgi.Parameters.AddWithValue("@p1", hesap.ToString());
            SqlDataReader dr = bilgi.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblHesapNo.Text = dr[5].ToString();
                lblTelefon.Text = dr[4].ToString();
                lblTcNo.Text = dr[3].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand toplamTutar = new SqlCommand("Select * From TblHesap Where HesapNo=@p1", baglanti);
            toplamTutar.Parameters.AddWithValue("@p1", hesap.ToString());
            SqlDataReader dr1 = toplamTutar.ExecuteReader();
            while (dr1.Read())
            {
                lblToplaTutar.Text = dr1[1].ToString();
            }
            kasa += decimal.Parse(lblToplaTutar.Text);
            baglanti.Close();

            grpCekme.Visible = false;
            grpHavale.Visible = false;
            grpYatirma.Visible = false;
        }

        //Yapılan işlen geçmişimizi görüntülemimizi sağlayan forma geçiyoruz.
        private void btnIslemGecmisi_Click(object sender, EventArgs e)
        {
            frmHareketler fr = new frmHareketler();
            fr.hesap = hesap;
            fr.Show();
        }

        //Para Yatırma işlemi kodlarımız
        private void btnParaYatir_Click(object sender, EventArgs e)
        {          
            //Gönderen hesabın para artışı
            baglanti.Open();
            SqlCommand HavaleDüsüs = new SqlCommand("Update TblHesap set Bakiye=Bakiye+@p1 Where HesapNo=@p2", baglanti);
            HavaleDüsüs.Parameters.AddWithValue("@p1", decimal.Parse(txtYatirTutar.Text));
            HavaleDüsüs.Parameters.AddWithValue("@p2", hesap);
            kasa += decimal.Parse(txtYatirTutar.Text);
            lblToplaTutar.Text = kasa.ToString();
            HavaleDüsüs.ExecuteNonQuery();
            baglanti.Close();

            //Yatir tablosundaki işlemleri gerçekleştiriyoruz
            baglanti.Open();
            SqlCommand yatir = new SqlCommand("insert into TblYatir (HesapNo,YatirilanTutar,Tarih) values (@p1,@p2,@p3)", baglanti);
            yatir.Parameters.AddWithValue("@p1", hesap);
            yatir.Parameters.AddWithValue("@p2", txtYatirTutar.Text);
            yatir.Parameters.AddWithValue("@p3", DateTime.Today);
            yatir.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Para Yatırma İşlemi Başarılı Bir Şekilde Gerçekleşti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtYatirTutar.Text = "";
            txtYatirTutar.Focus();
        }
        
        //Para Çekme işlemi yapan kodlar
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            //Gönderen hesabın para azalışı
            if (decimal.Parse(lblToplaTutar.Text)>0 || decimal.Parse(txtCekmeTutar.Text)- decimal.Parse(lblToplaTutar.Text)>0)
            {
                baglanti.Open();
                SqlCommand HavaleDüsüs = new SqlCommand("Update TblHesap set Bakiye=Bakiye-@p1 Where HesapNo=@p2", baglanti);
                HavaleDüsüs.Parameters.AddWithValue("@p1", decimal.Parse(txtCekmeTutar.Text));

                HavaleDüsüs.Parameters.AddWithValue("@p2", hesap);
                kasa -= decimal.Parse(txtCekmeTutar.Text);
                lblToplaTutar.Text = kasa.ToString();
                HavaleDüsüs.ExecuteNonQuery();
                baglanti.Close();

                //Çek tablosundaki işlemleri gerçekleştiriyoruz
                baglanti.Open();
                SqlCommand cek = new SqlCommand("insert into TblCek (HesapNo,CekilenTutar,Tarih) values (@p1,@p2,@p3)", baglanti);
                cek.Parameters.AddWithValue("@p1", hesap);
                cek.Parameters.AddWithValue("@p2", txtCekmeTutar.Text);
                cek.Parameters.AddWithValue("@p3", DateTime.Today);
                cek.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Para Çekme İşlemi Başarılı Bir Şekilde Gerçekleşti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCekmeTutar.Text = "";
                txtCekmeTutar.Focus();
            }
            else
            {
                MessageBox.Show("Para Çekme İşlemi Başarısız Oldu\nLütfen Hesabınızdaki Miktar Kadar Girin", "HATA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Havale işlemini yapan kodlar
        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            //Göderilen hesabın para artışı
            baglanti.Open();
            SqlCommand HavaleArtis = new SqlCommand("Update TblHesap set Bakiye=Bakiye+@p1 Where HesapNo=@p2", baglanti);
            HavaleArtis.Parameters.AddWithValue("@p1",decimal.Parse(txtHavaleTutar.Text));
            HavaleArtis.Parameters.AddWithValue("@p2", mtxtHesapNo.Text);
            HavaleArtis.ExecuteNonQuery();
            baglanti.Close();

            //Gönderen hesabın para azalışı
            baglanti.Open();
            SqlCommand HavaleDüsüs = new SqlCommand("Update TblHesap set Bakiye=Bakiye-@p1 Where HesapNo=@p2", baglanti);
            HavaleDüsüs.Parameters.AddWithValue("@p1", decimal.Parse(txtHavaleTutar.Text));
            HavaleDüsüs.Parameters.AddWithValue("@p2", hesap);
            kasa -= decimal.Parse(txtHavaleTutar.Text);
            lblToplaTutar.Text = kasa.ToString();
            HavaleDüsüs.ExecuteNonQuery();
            baglanti.Close();

            //Havale tablosundaki işlemleri gerçekleştiriyoruz
            baglanti.Open();
            SqlCommand hareket = new SqlCommand("insert into TblHavale (Gonderen,Alici,Tutar,Tarih) values (@p1,@p2,@p3,@p4)", baglanti);
            hareket.Parameters.AddWithValue("@p1", hesap);
            hareket.Parameters.AddWithValue("@p2", mtxtHesapNo.Text);
            hareket.Parameters.AddWithValue("@p3", txtHavaleTutar.Text);
            hareket.Parameters.AddWithValue("@p4", DateTime.Today);
            hareket.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Havale İşlemi Başarılı Bir Şekilde Gerçekleşti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtHavaleTutar.Text = "";
            txtHavaleTutar.Focus();
        }

        //Programı kapatıyoruz.
        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris fr = new frmGiris();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }


    }
}
