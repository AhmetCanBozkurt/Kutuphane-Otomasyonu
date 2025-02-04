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
//using Kutuphane;
namespace KutuphaneOtomsynFinal
{
    public partial class FormYetkiliIslemleri : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;

        public FormYetkiliIslemleri()
        {
            InitializeComponent();
        }
        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }
        public void yetkiliListele() // listeleme
        {
            baglantı();

            string komut = "select  admin.adminID,admin.ad,admin.soyad,admin.eMail,admin.sifre,admin.telefon,admin.adres from admin where admin.adminID=admin.adminID;";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        
        private void FormYetkiliIslemler_Load(object sender, EventArgs e)
        {
            yetkiliListele();
        }


        // Log ve admin tablosun gridi için..
        // log gridi her adminin yaptığı işlemleri listeler.
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglantı();
            SqlCommand komut = new SqlCommand("insert into admin (ad, soyad, eMail,sifre,telefon,adres) values(@ad, @soyad, @eMail, @sifre,@telefon,@adres)", con);

            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
            komut.Parameters.AddWithValue("@adres", adresTxt.Text);


            komut.ExecuteNonQuery();
            con.Close();
            yetkiliListele();

            MessageBox.Show("yetkili başarıyla kaydedildi.");
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            baglantı();
            SqlCommand komut = new SqlCommand("update  admin set ad=@ad, soyad=@soyad, eMail=@eMail,sifre=@sifre,telefon=@telefon,adres=@adres where adminID=@adminID ", con);

            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@eMail", emailTxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
            komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            komut.Parameters.AddWithValue("@adminID", yetkiliTxt.Text);


            komut.ExecuteNonQuery();
            con.Close();
            yetkiliListele();
            MessageBox.Show("yetkili başarıyla güncellendi.");
            
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı();
            string sorgu = "Delete from admin where adminID = @adminID";

            SqlCommand komut = new SqlCommand(sorgu, con);

            komut.Parameters.AddWithValue("@adminID", dataGridView1.CurrentRow.Cells[0].Value);

            komut.ExecuteNonQuery();
            con.Close();
            yetkiliListele();
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            if (yetkiliAraTxt.Text == "")
            {
                MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (yetkiliAraTxt.Text != "")
            {

                baglantı();
                string komut = "select *from admin where adminID='" + yetkiliAraTxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        //GRİD İŞLEMLERİ.............

      



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            yetkiliTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            adTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sifreTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            telefonTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            adresTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
       
    }
}
