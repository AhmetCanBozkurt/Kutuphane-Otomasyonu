using KtpOtomasyonu.Business.Concrete;
using KtpOtomasyonu.DataAccess.Concrete;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Database i çağırıcam

            UyelerManager _uyelerServices = new UyelerManager();

            foreach (var item in _uyelerServices.GetAllUye())
            {
                    MessageBox.Show(item.UyeNo.ToString());
            }

           

            //SqlConnection con;
            //SqlCommand komut;
            //SqlDataReader dr;


            //con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            //con.Open();

            //string guncellemekomutu = "Select * from Uyeler";
            //komut = new SqlCommand(guncellemekomutu, con);

            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{

            //      MessageBox.Show(dr["UyeNo"].ToString());

            //}


            //con.Close();





        }
    }
}
