using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal
{
    public class SifreGuvenlik
    {
        private int UzunlukPuanı(string password)
        {
            return Math.Min(10, password.Length) * 6;
        }

        private int KucukHarfPuanı(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int BuyukHarfPuanı(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int SayıPuanı(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int SembolPuanı(string password)
        {
            int rawScore = Regex.Replace(password, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        public class SifreGucuBelirt  //INNERCLASSS UYE VE PERSONEL EKLERKEN LABELDA GOSTERDİM İŞLEMLERİNE KOYDUM
        {
            public int GeneratePasswordScore(string password)
            {
                SifreGuvenlik sg = new SifreGuvenlik();
                if (password == null)
                {
                    return 0;
                }

                int lengthScore = sg.UzunlukPuanı(password);
                int lowerScore = sg.KucukHarfPuanı(password);
                int upperScore = sg.BuyukHarfPuanı(password);
                int digitScore = sg.SayıPuanı(password);
                int symbolScore = sg.SembolPuanı(password);

                return lengthScore + lowerScore + upperScore + digitScore + symbolScore;
            }
            public enum PasswordStrength
            {
                Kabuledilemez,
                Zayıf,
                Normal,
                Güçlü,
                Güvenli
            }



            public PasswordStrength GetPasswordStrength(string password)
            {

                int score = GeneratePasswordScore(password);

                if (score < 50)
                    return PasswordStrength.Kabuledilemez;
                else if (score < 60)
                    return PasswordStrength.Zayıf;
                else if (score < 80)
                    return PasswordStrength.Normal;
                else if (score < 90)
                    return PasswordStrength.Güçlü;
                else
                    return PasswordStrength.Güvenli;
            }

        }








    }
}
