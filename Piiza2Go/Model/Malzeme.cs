using System;
using System.Collections.Generic;
using System.Text;

namespace Piiza2Go.Model
{
    public class Malzeme
    {
        private int _fiyat;
        public int Fiyat { 
            set {
                _fiyat = 20;
                if (value > 0)
                    _fiyat = value;
                else
                    _fiyat = 1;
            }
            get
            {
                Console.WriteLine(DateTime.Now.ToString() + " tarihinde Fiyat bilgisi kullanıldı.");
                return _fiyat;
            }
        }

        public string Isim { get; set; }
    }
}
