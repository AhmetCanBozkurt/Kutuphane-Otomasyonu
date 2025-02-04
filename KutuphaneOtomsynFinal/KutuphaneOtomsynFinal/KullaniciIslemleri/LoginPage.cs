using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomsynFinal.KullaniciIslemleri
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (sifregosterkapat.Checked == false && sifre.Text != "Şifre Giriniz!")
            {
                sifre.PasswordChar = '*';
            }
            else
            {
                sifre.PasswordChar = '\0';
            }
            // var result = MessageBox.Show("Test");
            kAdi.GotFocus += Fokusum;
            kAdi.LostFocus += FokusumGitti;
        }

        private void Fokusum(object sender, EventArgs e)
        {
          
            if (kAdi.Text == "E-Mail")
            {
                kAdi.Text = "";
                kAdi.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void FokusumGitti(object sender, EventArgs e)
        {
          
            if (kAdi.Text != "E-Mail")
            {
                kAdi.Text = "E-Mail";
                kAdi.ForeColor = System.Drawing.Color.Gray;
            }
        }


        #region Şifre Gösterme
        private void sifregosterkapat_CheckedChanged(object sender, EventArgs e)
        {
            if (sifre.Text == "Şifre Giriniz!")
            {
                sifregosterkapat.Checked = false;
                return;
            }


            if (sifregosterkapat.Checked == true)
            {
                sifre.PasswordChar = '\0';
            }
            else
            {
                sifre.PasswordChar = '*';
            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            // Text ilk halindeyse sıfırla placeholder ile aynı mantıkla çalışır.

            if (sifre.Text == "Şifre Giriniz!")
            {
                sifre.Text = "";
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre Giriniz!";
                sifre.PasswordChar = '\0';
                sifregosterkapat.Checked = false;
            }
        }


      
        private void sifre_TextChanged(object sender, EventArgs e)
        {
           if (sifregosterkapat.Checked == true)
           {
               sifre.PasswordChar = '\0';
           }
           else
            {
                sifre.PasswordChar = '*';
            }
        }

        #endregion

        #region Çıkış İşlemleri
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            // Emin misiniz diye yazacağız.

            var result = MessageBox.Show(" Kapatmak İstiyor Musunuz?", "Bilgi", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);


            if (result == DialogResult.OK) {

                        this.Close();  // bulunduğu formu kapatıyor

                        Application.Exit();  // Programı kapatıyor

            }



        }

           #endregion

        #region Drag And Drop İle formun konumu taşıma

        // drag and drop mantığı 

        int Mouse_X, Mouse_Y;
        bool TiklandiMi = false;
     

        private void MouseHareketiniAl(object sender, MouseEventArgs e)
        {
            // Buradan geçtiğinde hareket var olduğunu algılayacağız.


            // mousenın konumunu tutmamamız gerekiyor

            Mouse_X = e.X; 
            Mouse_Y = e.Y;
            TiklandiMi = true;
           //  MessageBox.Show(Mouse_X.ToString() + "    " + Mouse_Y.ToString());

        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            TiklandiMi = false;
        }

   
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (TiklandiMi) {


                // Anlık olarak yeni konuma göre pencereyi getir.
                this.SetDesktopLocation(MousePosition.X -   Mouse_X, MousePosition.Y -  Mouse_Y);

                //MessageBox.Show(Mouse_X.ToString() + "    " + Mouse_Y.ToString());
            }    
        }

        #endregion
    }
}
