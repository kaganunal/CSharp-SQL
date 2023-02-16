using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgileriClass
{
    internal class Ogrenci
    {
        private string _adSoyad;
        private string _tcKimlikNo;
        private int _ogrenciNo;

        public string AdSoyad
        {
            get
            {
                return _adSoyad;
            }

            set
            {
                _adSoyad = value;
            }
        }

        public string TCKimlikNo
        {
            get
            {
                return _tcKimlikNo;
            }
            set
            {
                _tcKimlikNo = value;
            }
        }

        public int OgrenciNo
        {
            get
            {
                return _ogrenciNo;
            }
            set
            {
                _ogrenciNo = value;
            }
        }

        public bool TCNoKontrol()
        {
            if (_tcKimlikNo.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OgrenciNoKontrol()
        {
            if (_ogrenciNo.ToString().Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
