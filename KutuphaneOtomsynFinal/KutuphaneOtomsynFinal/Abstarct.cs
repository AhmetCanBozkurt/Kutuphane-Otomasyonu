using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal
{
  
    public abstract  class Abstarct //p  PERSONELİŞLEMLERİNDE PERSONEL ARAMADA  VE EMANETİŞLEMLERİNDE UYE ARAMADA   kullandım
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;
        public int id;
        public int idp;//ad
        abstract public DataTable ozellikyaz();

        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-T81CUTM\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();
        }
       public  class personelara : Abstarct
        {
            public override DataTable ozellikyaz()
            {
                    baglantı();
                    string komut = "select *from personel where personelID='" + idp + "'";//ad
                    SqlDataAdapter da = new SqlDataAdapter(komut, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
            }
        }

        public class emanetara : Abstarct
        {
            public override DataTable ozellikyaz()
            {
                baglantı();
                string komut = "select *from uye where uyeID='" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
