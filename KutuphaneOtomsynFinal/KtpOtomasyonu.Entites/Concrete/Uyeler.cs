using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtpOtomasyonu.Entities
{
    public class Uyeler
    {

        [Key]
        public int UyeNo { get; set; }
        public string UyeAd { get; set; }

        [Required]
        public string UyeSoyad { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeEposta { get; set; }
        public string UyeAdres { get; set; }


        public string UyeTest { get; set; }
    }
}
