using System;
using System.Collections.Generic;
using System.Text;

namespace OyunApp.Business.Abstract
{
    interface IOyuncu
    {
        string Adi { get; }

        void Save(IOyuncu oyuncu);
        void Update(IOyuncu oyuncu);
        void Delete(IOyuncu oyuncu);
    }
}
