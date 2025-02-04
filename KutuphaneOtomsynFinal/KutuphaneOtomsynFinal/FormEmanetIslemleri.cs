
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
    public partial class FormEmanetIslemleri : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;

        
        public FormEmanetIslemleri()
        {
            InitializeComponent();
        }
        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }
        public void uyeListele() // listeleme
        {
            baglantı();
            
            string komut = "select  uye.uyeID,uye.ad,uye.soyad,uye.eMail,uye.telefon,uye.adres,uye.uyelikDurumu from uye where uye.uyeID=uye.uyeID;";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewuye.DataSource = dt;

        }
        public void kitapListele() // listeleme
        {
            baglantı();
            
            string komut = "select kitap.kitapID,kitap.ISBN,kitap.ad,kitap.yazar,kitap.kategori,kitap.baskiYili,kitap.yayinEvi,kitap.fotograf,kitap.kitapDurumu from kitap where kitap.kitapID=kitap.kitapID";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewkitap.DataSource = dt;

        }
        public void islemListele() // listeleme
        {
            baglantı();

            string komut = "select islem.islemID,islem.adi,islem.soyadi,islem.eMail,islem.telefon,islem.adres,kitap.kitapID,kitap.kitapDurumu,kitap.ad,kitap.yazar,islem.islemTarihi,islem.iadeTarihi from islem,kitap where islem.islemID=islem.islemID and islem.kitapID=kitap.kitapID";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewislem.DataSource = dt;

        }



        private void FormEmanetIslemleri_Load(object sender, EventArgs e)
        {
            // uye gridine veri çekme
            uyeListele();
            // Kitap gridine veri çekme
            kitapListele();
            //İşlem gridine veri çekme
            islemListele();
        }

        // BUTON İŞLEVLERİ...........................
        private void kitapAraBtn_Click(object sender, EventArgs e) // KAPSULLEME  ka.ID KİTAPARA  ID YE GORE 
        {
            Kapsulleme ka = new Kapsulleme();
            ka.ID = int.Parse(kitapAraTxt.Text);

            if (ka.ID.ToString() == "")
            {
                MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (ka.ID.ToString() != "")
            {
                baglantı();
                string komut = "select *from kitap where kitapID='" + ka.ID + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewkitap.DataSource = dt;
            }
            kitapAraTxt.Text = "";
            //if (kitapAraTxt.Text == "")
            //{
            //    MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else if (kitapAraTxt.Text != "")
            //{

            //    baglantı();
            //    string komut = "select *from kitap where kitapID='" + kitapAraTxt.Text + "'";
            //    SqlDataAdapter da = new SqlDataAdapter(komut, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridViewkitap.DataSource = dt;
            //}
        }
        private void uyeAraBtn_Click(object sender, EventArgs e) // UYEARA ID YE GORE 
        {

            Abstarct.emanetara pa = new Abstarct.emanetara();
            pa.id = int.Parse(uyeAraTxt.Text);
            if (pa.id.ToString() == "")
            {
                MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (pa.id.ToString() != "")
            {
                //baglantı();
                //string komut = "select *from uye where uyeID='" + uyeAraTxt.Text + "'";
                //SqlDataAdapter da = new SqlDataAdapter(komut, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                dataGridViewuye.DataSource = pa.ozellikyaz();
            }
            uyeAraTxt.Text = "";
        }
        private void islemAraBtn_Click(object sender, EventArgs e)
        {
            if (islemAraTxt.Text == "")
            {
                MessageBox.Show("Lütfen gönderi numaranızı doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (islemAraTxt.Text != "")
            {
                baglantı();
                string komut = "select *from islem where islemID='" + islemAraTxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewislem.DataSource = dt;
            }
            islemAraTxt.Text = "";
        }
        private void verTemizleBtn_Click(object sender, EventArgs e)
        {
            textBoxad.Clear();
            textBoxsoyad.Clear();
            textBoxtel.Clear();
            textBoxadrs.Clear();
            textBoxemail.Clear();
            kitapIDTxt.Clear();
            durumTxti.BackColor = Color.White;
            durumTxti.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            uyeAraTxt.Clear();
            kitapAraTxt.Clear();
            islemAraTxt.Clear();
            uyeListele();
            kitapListele();
            

        }
        private void verBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (durumTxti.Text=="0")
                {
                    MessageBox.Show("KİTAP STOKTA YOK ");
                }
                else
                {
                    string eklemekomut = "insert into islem(islemID,kitapID,islemTarihi,iadeTarihi,adi,soyadi,eMail,telefon,adres)values (@islemID,@kitapID,@islemTarihi,@iadeTarihi,@adi,@soyadi,@eMail,@telefon,@adres)";
                    komut = new SqlCommand(eklemekomut, con);
                    komut.Parameters.AddWithValue("@islemID", textBoxiid.Text);
                    komut.Parameters.AddWithValue("@kitapID", kitapIDTxt.Text);
                    komut.Parameters.AddWithValue("@islemTarihi", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@iadeTarihi", dateTimePicker2.Value);
                    komut.Parameters.AddWithValue("@adi", textBoxad.Text);
                    komut.Parameters.AddWithValue("@soyadi", textBoxsoyad.Text);
                    komut.Parameters.AddWithValue("@eMail", textBoxemail.Text);
                    komut.Parameters.AddWithValue("@telefon", textBoxtel.Text);
                    komut.Parameters.AddWithValue("@adres", textBoxadrs.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni işlem kaydedildi !");
                    con.Close();
                }
                islemListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void alBtn_Click(object sender, EventArgs e)
        {
            baglantı();
            string sorgu = "Delete from islem where islemID = @islemID";

            SqlCommand komut = new SqlCommand(sorgu, con);

            komut.Parameters.AddWithValue("@islemID", dataGridViewislem.CurrentRow.Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Teslim alma kaydedildi !");
            islemListele();
            con.Close();
        }






        //DATAGRİDLERDEN VERİ ÇEKME

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapIDTxt.Text = dataGridViewkitap.CurrentRow.Cells[0].Value.ToString();
            durumTxti.Text = dataGridViewkitap.CurrentRow.Cells[8].Value.ToString();

        }
        private void dataGridViewuye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxad.Text= dataGridViewuye.CurrentRow.Cells[1].Value.ToString();
            textBoxsoyad.Text= dataGridViewuye.CurrentRow.Cells[2].Value.ToString();
            textBoxemail.Text = dataGridViewuye.CurrentRow.Cells[3].Value.ToString();
            textBoxtel.Text= dataGridViewuye.CurrentRow.Cells[4].Value.ToString();
            textBoxadrs.Text= dataGridViewuye.CurrentRow.Cells[5].Value.ToString();
        }
        

        private void uyeAraTxt_Leave(object sender, EventArgs e)
        {
           
            uyeListele();
            
        }

        private void kitapAraTxt_Leave(object sender, EventArgs e)
        {
            
            kitapListele();
        }

        private void islemAraTxt_Leave(object sender, EventArgs e)
        {
            
            islemListele();
        }


    }
}
