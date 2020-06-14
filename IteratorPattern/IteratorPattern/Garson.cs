using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Garson
    {
        private Menu _menu;

        public Garson(Menu menu)
        {
            _menu = menu;
        }


        public void Yaz()
        {
            _menu.Yaz();
        }
    }
}
