using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Kayısı";
            urun1.Fiyati = 45;
            urun1.Aciklama = "Amasya Kayısısı";

            Urun urun2 = new Urun();
            urun2.Adi = "Bal";
            urun2.Fiyati = 120;
            urun2.Aciklama = "Divriği balı";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("******************");
            }

            Console.WriteLine("*************Methods*************");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
