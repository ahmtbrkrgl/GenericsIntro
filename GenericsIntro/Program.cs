using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Sivas");

            Console.WriteLine(sehirler.Count);

            sehirler.Add("Tokat");

            Console.WriteLine(sehirler.Count);

            sehirler.Add("Trabzon");

            Console.WriteLine(sehirler.Count);

            foreach (var sehir in sehirler.Items)
            {
                Console.WriteLine(sehir);
            }

        }
    }
}
