using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class MenuEleman:IMenu
    {
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        private string _tanim;

        public string Tanim
        {
            get { return _tanim; }
            set { _tanim = value; }
        }

        private bool _vejetaryen;

        public bool Vejetaryen
        {
            get { return _vejetaryen; }
            set { _vejetaryen = value; }
        }

        private double _fiyat;

        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public MenuEleman(string ad, string tanim, bool vejetaryen, double fiyat)
        {
            _ad = ad;
            _tanim = tanim;
            _vejetaryen = vejetaryen;
            _fiyat = fiyat;
        }

        public void Yaz()
        {
            Console.WriteLine("{0}  -  {1}  -  vejetaryen: {2}  -  {3}",Ad, Tanim, Vejetaryen, Fiyat);
        }
    }
}
