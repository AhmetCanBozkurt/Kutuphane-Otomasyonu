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
    public partial class FormProfilAyarlari : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;
        public FormProfilAyarlari()
        {
            InitializeComponent();
        }
        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }
     

  
        private void FormProfilAyarlari_Load(object sender, EventArgs e)
        {
            emailTxt.Text = KullaniciBilgileri.email;
            sifreTxt.Text = KullaniciBilgileri.sifre;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı();
            SqlCommand komut = new SqlCommand("update admin set  eMail=@eMail,sifre=@sifre where adminID=@adminID ", con);

            komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            komut.Parameters.AddWithValue("@adminID", textBoxid.Text);
            komut.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("admin başarıyla güncellendi.");
        }

        //FORMDAN ÇIKIŞ
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
