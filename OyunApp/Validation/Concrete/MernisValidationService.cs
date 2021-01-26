using OyunApp.Validation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunApp.Validation.Conscrete
{
    class MernisValidationService : IValidationService
    {
        public void Validation(Oyuncu oyuncu)
        {
            if (oyuncu.Adi.Length > 1 && oyuncu.Soyadi.Length > 1 && oyuncu.Email.Length > 1)
            {
                Console.WriteLine(oyuncu.Adi + " " + oyuncu.Soyadi + " Mernis doğrulamasından geçti");
            }
            else
            {
                Console.WriteLine(oyuncu.Adi + " " + oyuncu.Soyadi + " Mernis doğrulamasından geçemedi");
            }
        }
    }
}
