﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Uygulamayı yukardan tutup süreklemek için



namespace KutuphaneOtomsynFinal
{
    public partial class FormUyeAnasayfa : Form
    {
        public FormUyeAnasayfa()
        {
            InitializeComponent();
        }
   
        private void FormUyeAnasayfa_Load(object sender, EventArgs e)
        {
            adSoyad.Text = KullaniciBilgileri.sifre;
            mailLabel.Text = KullaniciBilgileri.email;
        }

        // Uygulamayı yukardan tutup istediğimiz yere sürükleme ( --> using System.Runtime.InteropServices;  )
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //------------------------------------------------------------

        // YENİ AÇILAN FORMUN PANELCONTENT İÇİNDE YER ALMASI İÇİN AYARLAMALAR
        private void AbrirFormPanel(object Formhijo)
        {
            if (this.PanelContent.Controls.Count > 0)
            {
                this.PanelContent.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContent.Controls.Add(fh);
            this.PanelContent.Tag = fh;
            fh.Show();

        }
        //------------------------------------------------------------
        // ÇIKIŞ KÜÇÜLTME BÜYÜLTME TEPSİ MODUNA ALMA
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormFirstKitapScreen ffks = new FormFirstKitapScreen();
            ffks.Show();
            this.Close();
        }

        
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormal.Visible = true;
            btnMax.Visible = false;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMax.Visible = true;
        }


        // -----------------------------------------------------------


        // MOBILE MENU SLIDER

        private void timerKapaMenu_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width <= 80)
            {
                this.timerKapaMenu.Enabled = false;
            }
            else
            {
                this.PanelMenu.Width = PanelMenu.Width - 20;
            }
        }

        private void timerAcMenu_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width >= 220)
            {
                this.timerAcMenu.Enabled = false;
            }
            else
            {
                this.PanelMenu.Width = PanelMenu.Width + 20;
            }
        }

        private void mobileMenuSlider_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 220)
            {
                this.timerKapaMenu.Enabled = true;
            }
            else if (PanelMenu.Width == 80)
            {
                this.timerAcMenu.Enabled = true;
            }
        }
        // -----------------------------------------------------------

        // LOGO CLİCK
     

        private void logoBtn_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormFirstKitapScreen());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormFirstKitapScreen());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormFirstKitapScreen());
        }


        // -----------------------------------------------------------

        // GÜN-SAAT ( TIMER EKLEDİK ENABLED = TRUE)


        private void timerSaat_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {

          this.Close();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();
          
        }

        private void btnKitapIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormUyeUzerimdekiler());
            selectedBar.Visible = true;
            selectedBar.Height = btnKitapIslem.Height;
            selectedBar.Top = btnKitapIslem.Top;
        }

        private void btnUyeIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormUyeIadeEt());
            selectedBar.Visible = true;
            selectedBar.Height = btnUyeIslem.Height;
            selectedBar.Top = btnUyeIslem.Top;
        }

        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            FormProfilAyarlariUye pf = new FormProfilAyarlariUye();
            selectedBar.Visible = true;
            selectedBar.Height = btnEmanetIslem.Height;
            selectedBar.Top = btnEmanetIslem.Top;
            pf.ShowDialog();
        }

        private void FormUyeAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUyeAnasayfa fu = new FormUyeAnasayfa();
            FormFirstKitapScreen ffks = new FormFirstKitapScreen();
        }
        //--------------------------------------------------------------
    }
}
