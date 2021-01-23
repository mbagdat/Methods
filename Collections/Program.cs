using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string [] isimler=new string[] {"mutlu","ebru",""}

            List<string> isimler = new List<string> { "mutlu", "ebru", "canan", "necati" };
            isimler.Add("Hasan");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
        }
    }
}
