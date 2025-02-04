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
    public partial class FormFirstKitapScreen : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataReader dr;
        public FormFirstKitapScreen()
        {
            InitializeComponent();
            kitapListele();
        }

        public void baglantı()
        {
            con = new SqlConnection(@"Data Source=AHMETCANBOZKURT\SQLEXPRESS;Initial Catalog=kutuphaneotomasyon;Integrated Security=True");
            con.Open();

        }
       

        private void FormFirstScreen_Load(object sender, EventArgs e)
        {
          
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            icerikPanel.Visible = false;
            dataGridView1.Visible = true;
            if (araTxt.Text == "")
            {
                MessageBox.Show("Lütfen kitap adını doğru giriniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (araTxt.Text != "")
            {

                baglantı();
                string komut = "select kitap.kitapID,kitap.ISBN,kitap.ad,kitap.kategori,kitap.yazar,kitap.baskiYili,kitap.yayinEvi,kitap.fotograf,kitap.aciklama,kitap.sayfaSayisi from kitap  where ad='" + araTxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // LOGİN OLDUĞUMUZ FORMU AÇAR
        private void girisGitBtn_Click(object sender, EventArgs e)
        {
            FormGirisYap girisGit = new FormGirisYap();
            girisGit.ShowDialog();  // Bİ ÖNCEKİ FORMU KİTLEMEK İÇİN SHOW DİALOG KULLANDIK.
            

        }


        public void kitapListele() // listeleme
        {
            baglantı();
            string komut = "select kitap.kitapID,kitap.ISBN,kitap.ad,kitap.kategori,kitap.yazar,kitap.baskiYili,kitap.yayinEvi,kitap.fotograf,kitap.aciklama,kitap.sayfaSayisi from kitap where kitap.kitapID=kitap.kitapID;";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //TEXTBOX TASARIM
        private void araTxt_Enter(object sender, EventArgs e)
        {
            if (araTxt.Text == "Kitap Adı, Yazar Adı, ISBN")
            {
                araTxt.Text = "";
                araTxt.ForeColor = Color.Black;
            }
            kitapListele();
        }

        private void araTxt_Leave(object sender, EventArgs e)
        {
            if (araTxt.Text == "")
            {
                araTxt.Text = "Kitap Adı, Yazar Adı, ISBN";
                araTxt.ForeColor = Color.FromArgb(173, 173, 173);
            }
            kitapListele();
        }

        // GRİD TASARIM
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            gridStyle();
        }
        void gridStyle()
        {
            int i;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
