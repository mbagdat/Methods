using OyunApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunApp
{
    class Oyuncu : IOyuncu
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }

        public void Delete(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Adi + " İsimli kullanıcının silme işlemi başarı bir şekilde gerçekleşti");
        }

        public void Save(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Adi + " İsimli kullanıcının Kaydetme işlemi başarı bir şekilde gerçekleşti");
        }

        public void Update(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Adi + " İsimli kullanıcının Güncelleme işlemi başarı bir şekilde gerçekleşti");
        }
    }
}
