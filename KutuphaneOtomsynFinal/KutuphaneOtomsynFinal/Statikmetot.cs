using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal
{
   
   
    public  class Statikmetot
    {

        public static DataTable ulistele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T81CUTM\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

            string komut = "select  uye.uyeID,uye.ad,uye.soyad,uye.eMail,uye.sifre,uye.telefon,uye.adres from uye where uye.uyeID=uye.uyeID;";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
       

        
    }
  
}
