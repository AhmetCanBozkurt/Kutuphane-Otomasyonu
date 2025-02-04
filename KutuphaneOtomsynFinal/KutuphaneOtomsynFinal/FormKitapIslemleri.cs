using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using KutuphaneOtomsynFinal.Interfaceler;

namespace KutuphaneOtomsynFinal
{
    public partial class FormKitapIslemleri : Form
    {


        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;




        public FormKitapIslemleri()
        {
            InitializeComponent();
        }

        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }

        private void FormKitapIslemleri_Load(object sender, EventArgs e)
        {
            kitapListele();
         }

        public void kitapListele() // listeleme
        {
            //  baglantı();
            //  string komut = "select kitap.kitapID,kitap.ISBN,kitap.ad,kitap.kategori,kitap.yazar,kitap.baskiYili,kitap.yayinEvi,kitap.fotograf,kitap.aciklama,kitap.sayfaSayisi from kitap where kitap.kitapID=kitap.kitapID;";
            //  SqlDataAdapter da = new SqlDataAdapter(komut, con);
            //  DataTable dt = new DataTable();
            //  da.Fill(dt);  
            //dataGridView1.DataSource = dt;
            class3 gorevler3 = new class3(); ////////////////////////////////////////////////////////
            dataGridView1.DataSource =gorevler3.KitapListesi() ;

        }

        //picturebox a resim yüklemek..... (resimi boyutlandırır)
        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fotografPic.ImageLocation = openFileDialog1.FileName;
            textBox5.Text = openFileDialog1.FileName;


        }

       

        //KİTAP VERİLERİNİ VERİTABANINA EKLER.
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                baglantı();
                string eklemekomut = "insert into kitap(ISBN,ad,kategori,yazar,baskiYili,yayinEvi,sayfaSayisi,fotograf,aciklama,kitapDurumu) values (@ISBN,@ad,@kategori,@yazar,@baskiYili,@yayinEvi,@sayfaSayisi,@fotograf,@aciklama,@kitapDurumu)";
                komut = new SqlCommand(eklemekomut, con);
                komut.Parameters.AddWithValue("@ISBN", btnISBN.Text);
                komut.Parameters.AddWithValue("@ad", adTxt.Text);
                komut.Parameters.AddWithValue("@kategori", textBoxKategori.Text);
                komut.Parameters.AddWithValue("@yazar", yazarTxt.Text);
                komut.Parameters.AddWithValue("@baskiYili", baskiYiliTxt.Text);
                komut.Parameters.AddWithValue("@yayinEvi", yayinEviTxt.Text);
                komut.Parameters.AddWithValue("@sayfaSayisi", sayfaSayisiTxt.Text);
                komut.Parameters.AddWithValue("@fotograf", textBox5.Text);
                komut.Parameters.AddWithValue("@aciklama", aciklamaTxt.Text);
                komut.Parameters.AddWithValue("@kitapDurumu", textBoxktpdurumu.Text);
               
                komut.ExecuteNonQuery();
                kitapListele();
                MessageBox.Show("Yeni kitap  kaydedildi !");
              
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textTemizle();
        }

        //ISBN VERİSİNE GÖRE SİLME İŞLEMİ YAPAR
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı();
            string sorgu = "Delete from kitap where kitapID = @kitapID";

            SqlCommand komut = new SqlCommand(sorgu, con);

            komut.Parameters.AddWithValue("@kitapID", dataGridView1.CurrentRow.Cells[0].Value);
           
            komut.ExecuteNonQuery();
           
            kitapListele();
            MessageBox.Show("Başarıyla Silindi !");
            con.Close();
            textTemizle();
        }

        //gridden çekilen verileri yerleştirme
        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            try
            {

                baglantı();

                string eklemekomut = " update kitap set ISBN=@ISBN,ad=@ad,kategori=@kategori,yazar=@yazar,baskiYili=@baskiYili,yayinEvi=@yayinEvi,sayfaSayisi=@sayfaSayisi,fotograf=@fotograf,aciklama=@aciklama, kitapDurumu=@kitapDurumu where  kitapID=@kitapID";
                komut = new SqlCommand(eklemekomut, con);
                komut.Parameters.AddWithValue("@ISBN", btnISBN.Text);
                komut.Parameters.AddWithValue("@ad", adTxt.Text);
                komut.Parameters.AddWithValue("@kategori", textBoxKategori.Text);
                komut.Parameters.AddWithValue("@yazar", yazarTxt.Text);
                komut.Parameters.AddWithValue("@baskiYili", baskiYiliTxt.Text);
                komut.Parameters.AddWithValue("@yayinEvi", yayinEviTxt.Text);
                komut.Parameters.AddWithValue("@sayfaSayisi", sayfaSayisiTxt.Text);
                komut.Parameters.AddWithValue("@fotograf", textBox5.Text);
                komut.Parameters.AddWithValue("@aciklama", aciklamaTxt.Text);
                komut.Parameters.AddWithValue("@kitapDurumu", textBoxktpdurumu.Text);
                komut.Parameters.AddWithValue("@kitapID", textBoxid.Text);


                komut.ExecuteNonQuery();
                kitapListele();
                MessageBox.Show("Yeni kitap  guncellendi !");

                con.Close();
                textTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

        // Ara textboxına girileni veritabanında sorgular ve gridde listeletir.

        private void btnAra_Click(object sender, EventArgs e)
        {
           
            
            if (kitapAraTxt.Text == "")
            {
                MessageBox.Show("Lütfen kitap adını doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (kitapAraTxt.Text != "")
            {
                //Buradaki arama genel arama bazlı olmalı 
                baglantı();
                string komut = "select *from kitap  where kitapID='" + kitapAraTxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        
      

        //Textbox içini temizler
        public void textTemizle()
        {
            btnISBN.Text = "";
            adTxt.Text = "";
            textBox5.Text = "";
            yazarTxt.Text = "";
            sayfaSayisiTxt.Text = "";
            yayinEviTxt.Text = "";
            baskiYiliTxt.Text = "";
            aciklamaTxt.Text = "";
            fotografPic.Image = null;
            textBoxKategori.Text = "";
            textBoxid.Text = "";
            textBoxktpdurumu.Text = "";
        }
       
       

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            btnISBN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxKategori.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yazarTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            baskiYiliTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            yayinEviTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            fotografPic.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            aciklamaTxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            sayfaSayisiTxt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBoxktpdurumu.Text= dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

     

        private void kitapAraTxt_Leave(object sender, EventArgs e)
        {
            kitapListele();
            
        }

       
    }
}
