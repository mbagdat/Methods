using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriAdi = "Mutlu";
            gercekMusteri.MusteriSoyadi = "Bağdat";
            gercekMusteri.MusteriNo = "123";
            gercekMusteri.MusteriTcNo = "1234567";


            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo="345678";
            tuzelMusteri.SirketAdi = "yazilim dünyası";
            tuzelMusteri.MusteriVergiNo = "34235345345";



            
        }
    }
}
