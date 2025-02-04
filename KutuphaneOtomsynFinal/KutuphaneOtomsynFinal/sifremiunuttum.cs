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
    public partial class sifremiunuttum : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;

        public sifremiunuttum()
        {
            InitializeComponent();
        }

        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }

        private void sifremiunuttum_Load(object sender, EventArgs e)
        {
            kAdiu.Hide();
            sifreu.Hide();
            sifretekraru.Hide();
            buttonu.Hide();
            kAdi.Hide();
            sifre.Hide();
            sifretekrarı.Hide();
            button1.Hide();
        }


        public void psifreDegistir()//PERSONEL İÇİN yönetici şifre değiştir
        {
            try
            {
                baglantı();
                string guncellemekomutu = "update personel set eMail='" + this.kAdi.Text + "', sifre ='" + this.sifre.Text + "';";
                komut = new SqlCommand(guncellemekomutu, con);

                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                }
                con.Close();

                MessageBox.Show("Yeni personel şifreniz oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void usifreDegistir()//UYE İÇİN yönetici şifre değiştir
        {
            try
            {
                baglantı();
                string guncellemekomutu = "update uye set eMail='" + this.kAdiu.Text + "', sifre ='" + this.sifreu.Text + "';";
                komut = new SqlCommand(guncellemekomutu, con);

                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                }
                con.Close();

                MessageBox.Show("Yeni uye şifreniz oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            if (kAdi.Text.Contains("@") && kAdi.Text.Contains(".com"))
            {
                if (sifre.Text == sifretekrarı.Text)
                {
                    psifreDegistir();
                 
                }
                else
                {
                    MessageBox.Show("lütfen şifre alanlarını birbiriyle eşit yapınız", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("lütfen mail adresini doğru giriniz");

            }
        }

        private void buttonuye_Click(object sender, EventArgs e)
        {
            kAdiu.Show();
            sifreu.Show();
            sifretekraru.Show();
            buttonu.Show();
        }

        private void buttonpersonel_Click(object sender, EventArgs e)
        {
            kAdi.Show();
            sifre.Show();
            sifretekrarı.Show();
            button1.Show();
        }

        private void buttonu_Click(object sender, EventArgs e)
        {
            if (kAdiu.Text.Contains("@") && kAdiu.Text.Contains(".com"))
            {
                if (sifreu.Text == sifretekraru.Text)
                {
                    usifreDegistir();

                }
                else
                {
                    MessageBox.Show("lütfen şifre alanlarını birbiriyle eşit yapınız", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("lütfen mail adresini doğru giriniz");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
