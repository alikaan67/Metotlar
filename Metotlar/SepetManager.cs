using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    //naming convention
    //syntax
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler,sepete eklendi :" + urun.Adi);
        }



        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)
        {
            Console.WriteLine("Tebrikler,sepete eklendi :" + urunAdi);

        }

    }
}  

