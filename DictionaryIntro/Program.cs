using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> nameAge = new MyDictionary<string,int>();
            nameAge.Add("Ahmet",20);
            Console.WriteLine(nameAge.Count);

            nameAge.Add("Burak",21);
            Console.WriteLine(nameAge.Count);

            nameAge.Add("Karagöl",22);
            Console.WriteLine(nameAge.Count);

            foreach (var key in nameAge.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in nameAge.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
