using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mutlu");

            //Console.WriteLine(isimler.Length);

            //isimler.Add("Ebru");
            //Console.WriteLine(isimler.Length);
        }
    }
}
