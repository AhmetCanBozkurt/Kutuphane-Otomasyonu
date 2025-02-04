using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal.Interfaceler
{
   public class class2 : Inter2
    {
        //baglantı adresi
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T81CUTM\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");



        public void Delete(int uyeID)   //UYE SİLME
        {
            con.Open();
            string sorgu = "Delete from uye where uyeID = @uyeID";
            SqlCommand komut = new SqlCommand(sorgu, con);
            komut.Parameters.AddWithValue("@uyeID", uyeID);

            komut.ExecuteNonQuery();
            con.Close();

        }

        public DataTable GetByID(int uyeid) // UYE ARAMA
        {
            con.Open();
            string komut = "select *from uye where uyeID='" + uyeid + "'";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
