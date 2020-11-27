using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankamatikSimilasyonu
{
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }
        public string hesap;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MN3O9G6\SQLEXPRESS;Initial Catalog=DbBankamatik;User ID=sa;Password=m10zxcvb");

        private void frmHareketler_Load(object sender, EventArgs e)
        {
            //Havale geçmişini görüntülemek için kodlar
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblHavale Where Gonderen='" + hesap + "' or Alici='" + hesap + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHavale.DataSource = dt;
            baglanti.Close();

            //Yatırma geçmişini görüntülemek için kodlar
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From TblYatir Where HesapNo='" + hesap + "'", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvYatirma.DataSource = dt1;
            baglanti.Close();

            //Çekme geçmişini görüntülemek için kodlar
            baglanti.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TblCek Where HesapNo='" + hesap + "'", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvCekme.DataSource = dt2;
            baglanti.Close();
        }
    }
}
