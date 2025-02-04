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
    public partial class FormPersonelIslemleri : Form
    {

        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;


        public FormPersonelIslemleri()
        {
            InitializeComponent();
        }

        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();
        }

       
        public void personelListele() // listeleme
        {
            baglantı();

            string komut = "select  personel.personelID,personel.ad,personel.soyad,personel.eMail,personel.sifre,personel.telefon,personel.adres from personel where personel.personelID=personel.personelID;";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void FormPersonelIslemleri_Load(object sender, EventArgs e)
        {
            personelListele();
          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglantı();
           
            if (sifreTxt.Text == "")
            {
                MessageBox.Show("bos gecilemez");

            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into personel (ad, soyad, eMail,sifre,telefon,adres) values(@ad, @soyad, @eMail, @sifre,@telefon,@adres)", con);

                komut.Parameters.AddWithValue("@ad", adTxt.Text);
                komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
                komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
                komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
                komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
                komut.Parameters.AddWithValue("@adres", adresTxt.Text);


                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("personel başarıyla kaydedildi.");
            }
            
            personelListele();
            textTemizle();

          
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            baglantı();
            SqlCommand komut = new SqlCommand("update  personel set ad=@ad, soyad=@soyad, eMail=@eMail,sifre=@sifre,telefon=@telefon,adres=@adres where personelID=@personelID ", con);

            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
            komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            komut.Parameters.AddWithValue("@personelID", textBoxid.Text);


            komut.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("personel başarıyla güncellendi.");
            personelListele();
            textTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı();
            string sorgu = "Delete from personel where personelID = @personelID";

            SqlCommand komut = new SqlCommand(sorgu, con);

            komut.Parameters.AddWithValue("@personelID", dataGridView1.CurrentRow.Cells[0].Value);

            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("personel başarıyla kaldırıldı.");
            personelListele();
            textTemizle();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Abstarct.personelara pa = new Abstarct.personelara();
            pa.idp = int.Parse(personelAraTxt.Text);

            if (pa.idp.ToString() == "")
            {
                MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (pa.idp.ToString() != "")
            {
              
                dataGridView1.DataSource = pa.ozellikyaz();
            }
            //if (personelAraTxt.Text == "")
            //{
            //    MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else if (personelAraTxt.Text != "")
            //{

            //    baglantı();
            //    string komut = "select *from personel where ad='" + personelAraTxt.Text + "'";
            //    SqlDataAdapter da = new SqlDataAdapter(komut, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
        }

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


      

        //private void personelAraTxt_Enter(object sender, EventArgs e)
        //{
        //    if (personelAraTxt.Text == "Ad, Soyad, E-Mail")
        //    {
        //        personelAraTxt.Text = "";
        //        personelAraTxt.ForeColor = Color.Black;
        //    }

        //}

        //private void personelAraTxt_Leave(object sender, EventArgs e)
        //{
        //    if (personelAraTxt.Text == "")
        //    {
        //        personelAraTxt.Text = "Ad, Soyad, E-Mail";
        //        personelAraTxt.ForeColor = Color.FromArgb(171, 171, 171);
        //    }
        //}

        public void textTemizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
            telefonTxt.Text = "";
            emailTxt.Text = "";
            adresTxt.Text = "";
            sifreTxt.Text = "";
            textBoxid.Text= "";

        }

        private void sifreTxt_TextChanged(object sender, EventArgs e)  //INNER CLASS
        {
            SifreGuvenlik.SifreGucuBelirt sg = new SifreGuvenlik.SifreGucuBelirt();

            lblDerece.Text = (sg.GetPasswordStrength(sifreTxt.Text).ToString());
        }
    }
}
