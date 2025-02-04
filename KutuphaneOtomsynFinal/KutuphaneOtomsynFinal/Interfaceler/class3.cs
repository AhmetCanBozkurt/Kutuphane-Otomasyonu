using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal.Interfaceler
{
   public class class3 : Inter3
    {
        //baglantı adresi
        SqlConnection con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");

      

        public void Add(string ad, string soyad, string eMail, string sifre, string telefon, string adres)  //UYE EKLEME
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into uye (ad, soyad, eMail,sifre,telefon,adres) values(@ad, @soyad, @eMail, @sifre,@telefon,@adres)", con);

            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@eMail", eMail);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@telefon", telefon);
            komut.Parameters.AddWithValue("@adres", adres);

            komut.ExecuteNonQuery();
           

        }



        public void Update(string ad, string soyad, string eMail, string sifre, string telefon, string adres,int id)  //UYE GUNCELLEME
        {
            con.Open();
            SqlCommand komut = new SqlCommand("update  uye set ad=@ad, soyad=@soyad, eMail=@eMail,sifre=@sifre,telefon=@telefon,adres=@adres where uyeID=@uyeID ", con);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@eMail", eMail);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@telefon", telefon);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@uyeID", id);

            komut.ExecuteNonQuery();
            con.Close();
        }







        public DataTable KitapListesi() // FORMFIRST GIRIS KAPAK ARAMA
        {
            con.Open();
            string komut = "select kitap.kitapID,kitap.ISBN,kitap.ad,kitap.kategori,kitap.yazar,kitap.baskiYili,kitap.yayinEvi,kitap.fotograf,kitap.aciklama,kitap.sayfaSayisi,kitap.kitapDurumu from kitap where kitap.kitapID=kitap.kitapID;";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       
    }
}
