using OyunApp.Business.Abstract;
using OyunApp.Business.Concrete;
using OyunApp.Validation.Abstract;
using OyunApp.Validation.Conscrete;
using System;
using System.Collections.Generic;

namespace OyunApp
{
    class Program
    {
        static void Main(string[] args)

        {
            IValidationService validationService = new MernisValidationService();
            IOyuncu playerManager = new PlayerManager(new List<IValidationService> { validationService });

            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Id = 1;
            oyuncu1.Adi = "mutlu";
            oyuncu1.Soyadi = "bağdat";
            oyuncu1.Email = "abc@gmail.com";

            oyuncu1.Save(oyuncu1);
            oyuncu1.Update(oyuncu1);
            oyuncu1.Delete(oyuncu1);

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.Id = 2;
            oyuncu2.Adi = "ebu";
            oyuncu2.Soyadi = "türk";
            oyuncu2.Email = "def@gmail.com";

            oyuncu2.Save(oyuncu2);
            oyuncu2.Update(oyuncu2);
            oyuncu2.Delete(oyuncu2);

            Oyuncu oyuncu3 = new Oyuncu();
            oyuncu3.Id = 2;
            oyuncu3.Adi = "deneme";
            oyuncu3.Soyadi = "";
            oyuncu3.Email = "test@gmail.com";

            playerManager.Save(oyuncu1);
            playerManager.Save(oyuncu2);
            playerManager.Save(oyuncu3);
        }
    }
}
