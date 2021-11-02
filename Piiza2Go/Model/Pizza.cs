using System;
using System.Collections.Generic;
using System.Text;

namespace Piiza2Go.Model
{
    public class Pizza
    {

        //Malzemeler
        public List<Malzeme> Malzemeler { get; set; }
        //Hamur
        public HamurKalinligi Hamur { get; set; }
        //Boyut
        public Boyutlar Boyut { get; set; }
        //Sosu
        public int Sos { get; set; }
        //ToplamFiyat
        public DateTime SiparisTarihi { get; set; }
        public int ToplamFiyat
        {
            get
            {
                int calculatedPrice = 0;

                foreach (Malzeme malzeme in Malzemeler)
                {
                    calculatedPrice += malzeme.Fiyat;
                }

                calculatedPrice += Sos;

                return calculatedPrice;
            }
        }
        public string ReadableName
        {
            get
            {
                string readable = "";

                //Boyut Metni Belirle
                switch (Boyut)
                {
                    case Boyutlar.SMALL:
                        readable = "Küçük";
                        break;
                    case Boyutlar.MEDIUM:
                        readable = "Orta";
                        break;
                    case Boyutlar.LARGE:
                        readable = "Büyük";
                        break;
                    default:
                        break;
                }

                //Kalınlık Metni Belirle
                switch (Hamur)
                {
                    case HamurKalinligi.THIN:
                        readable += " İnce";
                        break;
                    case HamurKalinligi.NORMAL:
                        readable += " Normal";
                        break;
                    case HamurKalinligi.THICK:
                        readable += " Kalın";
                        break;
                    default:
                        break;
                }

                switch (Sos)
                {
                    case 0:
                        readable += " Az Soslu";
                        break;
                    case 1:
                        readable += " Orta Soslu";
                        break;
                    case 2:
                        readable += " Bol Soslu";
                        break;
                }
                readable += " " + ToplamFiyat.ToString() + "₺";
                return readable;
            }
        }

        public Pizza()
        {
            Malzemeler = new List<Malzeme>();
            Malzemeler.Add(new Malzeme()
            {
                Isim = "Mozerella",
                Fiyat = 2
            });
        }
    }
}
