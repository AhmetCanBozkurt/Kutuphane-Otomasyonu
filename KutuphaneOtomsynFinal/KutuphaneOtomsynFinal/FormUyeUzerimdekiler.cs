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
    public partial class FormUyeUzerimdekiler : Form
    {

        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;

        public FormUyeUzerimdekiler()
        {
            InitializeComponent();
        }
        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }
        public void islemListele() // listeleme
        {
            baglantı();

            string komut = "select islem.islemID,islem.adi,islem.soyadi,islem.eMail,kitap.kitapID,kitap.ad,kitap.yazar,islem.islemTarihi,islem.iadeTarihi from islem,kitap where islem.islemID=islem.islemID and islem.kitapID=kitap.kitapID";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        //UYENİN ÜZERİNDE BULUNAN KİTAPLARI LİSTELER..
        private void FormUyeUzerimdekiler_Load(object sender, EventArgs e)
        {
           islemListele();
        }


        private void button_7_Click(object sender, EventArgs e)
        {
            tarihAyarla(7);
        }


        private void button_15_Click(object sender, EventArgs e)
        {
            tarihAyarla(15);
        }

        private void button_30_Click(object sender, EventArgs e)
        {
            tarihAyarla(30);
        }



        private void tarihAyarla(int v)
        {
            dateTimePicker_TeslimTarihi.Value = DateTime.Now.AddDays(v);
        }


        //ÜYENİN ALDIĞI KİTABIN İADE TARİHİE  UZATMA HAKKI TANIR.. 
        private void uzatBtn_Click(object sender, EventArgs e)
        {
            baglantı();

            string eklemekomut = " update islem set iadeTarihi=@iadeTarihi where  islemID=@islemID";
            komut = new SqlCommand(eklemekomut, con);
           
            komut.Parameters.AddWithValue("@iadeTarihi",DateTime.Parse(dateTimePicker_TeslimTarihi.Text));
            komut.Parameters.AddWithValue("@islemID", textBoxid.Text);


            komut.ExecuteNonQuery();
            islemListele();
            MessageBox.Show("iade tarihi  guncellendi !");

            con.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            dateTimePicker_TeslimTarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxid.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();


        }

       
    }
}
