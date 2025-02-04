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
    public partial class FormProfilAyarlariPersonel : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;
        public FormProfilAyarlariPersonel()
        {
            InitializeComponent();
        }
        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();
        }
        private void FormProfilAyarlariPersonel_Load(object sender, EventArgs e)
        {
            emailTxt.Text = KullaniciBilgileri.email;
            sifreTxt.Text = KullaniciBilgileri.sifre;
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            baglantı();
            SqlCommand komut = new SqlCommand("update  personel set  eMail=@eMail,sifre=@sifre where personelID=@personelID ", con);

            komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            komut.Parameters.AddWithValue("@personelID", textBoxid.Text);
            komut.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("personel başarıyla güncellendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
