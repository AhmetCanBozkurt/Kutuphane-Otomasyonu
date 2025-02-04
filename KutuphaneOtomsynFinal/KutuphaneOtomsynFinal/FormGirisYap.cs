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
using KutuphaneOtomsynFinal;


namespace KutuphaneOtomsynFinal
{
    public partial class FormGirisYap : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;
        public static string degisken;
        public FormGirisYap()
        {
            InitializeComponent();
        }

        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }


        // Giriş yapan kişinin kaydının olup olmadığının kontrolü, kayıtlıysa sisteme giriş yapması değilse gerekli hata mesajlarını göstermesi...
        private void girisBtn_Click(object sender, EventArgs e) //A
        {
            baglantı();
            komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "select * from admin where eMail='" + kAdi.Text + "'AND password='" + sifre.Text + "'";
            
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                degisken = kAdi.Text;
                this.Hide();

                KullaniciBilgileri.email = kAdi.Text; // STATİK DEĞİŞKEN
                KullaniciBilgileri.sifre= sifre.Text;//STATİK DEĞİŞKEN
                if (radioAdmin.Checked)
                {
                   
                    FormAdminAnasayfa fa = new FormAdminAnasayfa();
                    fa.ShowDialog();
                    
                }
            }
            else
            {
                DialogResult secim = MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (secim == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }
        private void girisBtnp_Click(object sender, EventArgs e)//P
        {
            baglantı();
            komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "select * from personel where eMail='" + kAdi.Text + "'AND password='" + sifre.Text + "'";

            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                degisken = kAdi.Text;
                this.Hide();

                KullaniciBilgileri.email = kAdi.Text;
                KullaniciBilgileri.sifre = sifre.Text;


                if (radioPersonel.Checked)
                {
                   
                    FormPersonelAnasayfa fp = new FormPersonelAnasayfa();
                    fp.ShowDialog();
                }
            }
            else
            {
                DialogResult secim = MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (secim == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void girisBtnk_Click(object sender, EventArgs e)//K
        {
            baglantı();
            komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "select * from uye where eMail='" + kAdi.Text + "'AND sifre='" + sifre.Text + "'";

            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                degisken = kAdi.Text;
                this.Hide();

                KullaniciBilgileri.email = kAdi.Text;
                KullaniciBilgileri.sifre = sifre.Text;

                if (radioKullanici.Checked)
                {
                    
                    FormUyeAnasayfa fu = new FormUyeAnasayfa();
                    fu.ShowDialog();
                }
            }
            else
            {
                DialogResult secim = MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (secim == DialogResult.OK)
                {
                    this.Show();
                }
                
            }
           
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            girisBtn.Show();
        }

        private void radioPersonel_CheckedChanged(object sender, EventArgs e)
        {
            girisBtnp.Show();
        }

        private void radioKullanici_CheckedChanged(object sender, EventArgs e)
        {
            girisBtnk.Show();
        }


        // Form Çıkış Butonu
       

        // TASARIM İÇİN................
        private void kAdi_Enter(object sender, EventArgs e)
        {
            if (kAdi.Text == "E-Mail")
            {
                kAdi.Text = "";
                kAdi.ForeColor = Color.Black;
            }
        }

        private void kAdi_Leave(object sender, EventArgs e)
        {
            if (kAdi.Text == "")
            {
                kAdi.Text = "E-Mail";
                kAdi.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Şifre")
            {
                sifre.Text = "";
                sifre.ForeColor = Color.Black;
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre";
                sifre.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }

        private void FormGirisYap_Load(object sender, EventArgs e)
        {
            
            girisBtnp.Hide();
            girisBtnk.Hide();
            sifregk();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum si = new sifremiunuttum();
            si.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormFirstKitapScreen fs = new FormFirstKitapScreen();
            //fs.ShowDialog();
        }
        private void sifregk()
        {
            //checkBox işaretli ise
            if (sifregosterkapat.Checked)
            {
                //karakteri göster.
                sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifre.PasswordChar = '*';
            }
        }

        private void sifregosterkapat_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (sifregosterkapat.Checked)
            {

                ////karakteri göster.
                sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifre.PasswordChar = '*';
            }
        }
    }
}
