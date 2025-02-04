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
    public partial class FormUyeIslemleri : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;
       
        public FormUyeIslemleri()
        {
            InitializeComponent();
        }
       
        public void uyeListele() // listeleme
        {
            //baglantı();

            //string komut = "select  uye.uyeID,uye.ad,uye.soyad,uye.eMail,uye.sifre,uye.telefon,uye.adres from uye where uye.uyeID=uye.uyeID;";
            //SqlDataAdapter da = new SqlDataAdapter(komut, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            
        }

        private void FormUyeIslemleri_Load(object sender, EventArgs e)
        {
            //uyeListele();
            dataGridView1.DataSource= Statikmetot.ulistele();   //STATİK METOT 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //baglantı();
            //SqlCommand komut = new SqlCommand("insert into uye (ad, soyad, eMail,sifre,telefon,adres) values(@ad, @soyad, @eMail, @sifre,@telefon,@adres)", con);
            //komut.Parameters.AddWithValue("@ad", adTxt.Text);
            //komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            //komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            //komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            //komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
            //komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            //komut.ExecuteNonQuery();
            string ad, soyad, eMail, sifre, telefon, adres;
            ad = adTxt.Text;
            soyad = soyadTxt.Text;
            eMail=emailTxt.Text;
            sifre = sifreTxt.Text;
            telefon = telefonTxt.Text;
            adres = adresTxt.Text;
            if (sifreTxt.Text=="")
            {
                MessageBox.Show("bos gecilemez");

            }
            else
            {
                Interfaceler.class3 c = new Interfaceler.class3();
                c.Add(ad, soyad, eMail, sifre, telefon, adres);
                //con.Close();
                dataGridView1.DataSource = Statikmetot.ulistele();

                MessageBox.Show("uye başarıyla kaydedildi.");
            }
           
            textTemizle();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            //baglantı();
            //SqlCommand komut = new SqlCommand("update  uye set ad=@ad, soyad=@soyad, eMail=@eMail,sifre=@sifre,telefon=@telefon,adres=@adres where uyeID=@uyeID ", con);
            //komut.Parameters.AddWithValue("@ad", adTxt.Text);
            //komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            //komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            //komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            //komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
            //komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            //komut.Parameters.AddWithValue("@uyeID", textBoxid.Text);
            //komut.ExecuteNonQuery();
            string ad, soyad, eMail, sifre, telefon, adres;
            int id;
            ad = adTxt.Text;
            soyad = soyadTxt.Text;
            eMail = emailTxt.Text;
            sifre = sifreTxt.Text;
            telefon = telefonTxt.Text;
            adres = adresTxt.Text;
            id =int.Parse(textBoxid.Text);
            Interfaceler.class3 c = new Interfaceler.class3();
            c.Update(ad, soyad, eMail, sifre, telefon, adres,id);
            //con.Close();
            dataGridView1.DataSource = Statikmetot.ulistele();
            MessageBox.Show("uye başarıyla güncellendi.");
            textTemizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            //baglantı();
            //string sorgu = "Delete from uye where uyeID = @uyeID";
            //SqlCommand komut = new SqlCommand(sorgu, con);
            //komut.Parameters.AddWithValue("@uyeID", dataGridView1.CurrentRow.Cells[0].Value);
            //komut.ExecuteNonQuery();
            int uyeID;
            uyeID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Interfaceler.class2 c = new Interfaceler.class2();
            c.Delete(uyeID);
            //con.Close();
            dataGridView1.DataSource = Statikmetot.ulistele();
            MessageBox.Show("uye başarıyla kaldırıldı.");
            textTemizle();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            //if (uyeAraTxt.Text == "")
            //{
            //    MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (uyeAraTxt.Text != "")
            //{
            //    baglantı();
            //    string komut = "select *from uye where uyeID='" + uyeAraTxt.Text + "'";
            //    SqlDataAdapter da = new SqlDataAdapter(komut, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
            if (uyeAraTxt.Text == "")
            {
                MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (uyeAraTxt.Text != "")
            {
                int uyeid;
                uyeid = int.Parse(uyeAraTxt.Text);
                Interfaceler.class2 c = new Interfaceler.class2();
                
               dataGridView1.DataSource= c.GetByID(uyeid);

            }
        }

        //tıklandığında verileri alanlara çeker.
        // string adTxt2, soyadTxt2, emailTxt2, telefonTxt2, adresTxt2;



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                adTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                soyadTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                emailTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sifreTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                telefonTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                adresTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
        }


        private void uyeAraTxt_Leave(object sender, EventArgs e)
        {
            if (uyeAraTxt.Text == "Ad, Soyad, E-Mail")
            {
                uyeAraTxt.Text = "";
                uyeAraTxt.ForeColor = Color.Black;
            }
        }

        private void uyeAraTxt_Enter(object sender, EventArgs e)
        {
            if (uyeAraTxt.Text == "")
            {
                uyeAraTxt.Text = "Ad, Soyad, E-Mail";
                uyeAraTxt.ForeColor = Color.FromArgb(171, 171, 171);
            }
        }



        public void textTemizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
            telefonTxt.Text = "";
            emailTxt.Text = "";
            adresTxt.Text = "";
            sifreTxt.Text = "";
            textBoxid.Text = "";

        }

        private void sifreTxt_TextChanged(object sender, EventArgs e)  //INNERCLASS
        {
            SifreGuvenlik.SifreGucuBelirt sg = new SifreGuvenlik.SifreGucuBelirt();

            lblDerece.Text = (sg.GetPasswordStrength(sifreTxt.Text).ToString());
        }

        private void lblDerece_Click(object sender, EventArgs e)
        {

        }
    }
}
