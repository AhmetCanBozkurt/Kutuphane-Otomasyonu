using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal.Interfaceler
{
   public  interface Inter1
    {
        void Add(string ad, string soyad, string  eMail, string  sifre, string telefon, string  adres );
        void Update(string ad, string soyad, string eMail, string sifre, string telefon, string adres,int id);

        DataTable KitapListesi();
    }
}
