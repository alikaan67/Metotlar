﻿using Metotlar;

class Program
{

    static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyati = 15;
        string aciklama = "Amasya elması";

        string[] meyveler = new string[] { };

        Product urun1 = new Product();
        urun1.Adi = urunAdi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Product urun2 = new Product();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 15;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Product[] urunler = new Product[] {urun1,urun2};
        
        //type-safe --tip güvenli
        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("__________________");
        }
        Console.WriteLine("----------Metotlar----------");
        //instance - örnek
        //encapsulation
        SepetManager sepetManager= new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut", "Yesil Armut", 12,10);
        sepetManager.Ekle2("Elma", "Yesil Elma", 12,9);
        sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);


    }
}
