using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(06, "Ankara");
            cities.Add(34, "İstanbul");
            cities.Add(35, "İzmir");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
