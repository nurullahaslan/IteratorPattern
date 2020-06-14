using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Menu:IMenu
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

        public Menu(string ad, string tanim)
        {
            this.Ad = ad;
            this.Tanim = tanim;
        }

        List<IMenu> nodelar = new List<IMenu>();

        public void Ekle(IMenu node)
        {
            nodelar.Add(node);
        }


        public void Yaz()
        {
            Console.WriteLine("\n{0}  -  {1}",Ad, Tanim);
            Console.WriteLine("*********************************");
            foreach (IMenu node in nodelar)
            {
                node.Yaz();
            }
        }
    }
}
