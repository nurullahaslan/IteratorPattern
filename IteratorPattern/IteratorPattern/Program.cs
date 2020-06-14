using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu anaMenu = new Menu("Ana Menü", "Genel");
            Menu sicakIcecek = new Menu("İçecekler", "Sıcak İçecekler");
            Menu sogukIcecek = new Menu("İçecekler", "Soğuk İçecekler");

            MenuEleman e1 = new MenuEleman("Çay", "Yeşil Çay", true, 2);
            MenuEleman e2 = new MenuEleman("Çay", "Ihlamur", true, 2);
            MenuEleman e3 = new MenuEleman("Kola", "Diyet Kola", false, 2);
            MenuEleman e4 = new MenuEleman("Gazoz", "Sade Gazoz", false, 2);

            sicakIcecek.Ekle(e1);
            sicakIcecek.Ekle(e2);
            sogukIcecek.Ekle(e3);
            sogukIcecek.Ekle(e4);

            anaMenu.Ekle(sicakIcecek);
            anaMenu.Ekle(sogukIcecek);

            Garson goktug = new Garson(anaMenu);
            goktug.Yaz();
        }
    }
}
