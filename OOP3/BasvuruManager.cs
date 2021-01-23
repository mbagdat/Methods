using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediService krediService, ILoggerService loggerService)
        {
            krediService.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirme(List<IKrediService> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}
