using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomsynFinal
{
    public partial class FormUyeIadeEt : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;

        public FormUyeIadeEt()
        {
            InitializeComponent();
        }
        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }
        public void iadelistele()
        {
            baglantı();
            // string komut = "select  uye.uyeID,uye.ad,uye.soyad,uye.eMail,uye.telefon,uye.uyelikDurumu from uye where uye.uyeID=uye.uyeID;";
            string komut = "select islem.islemID,islem.adi,islem.soyadi,kitap.ad,kitap.fotograf,islem.iadeTarihi from islem,kitap where islem.kitapID=kitap.kitapID";
            
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //GİRİŞ YAPAN ÜYENİN İADE ETTİĞİ KİTAPLARI LİSTELER
        private void FormUyeIadeEt_Load(object sender, EventArgs e)
        {
            iadelistele();
        }

        
    }
}
