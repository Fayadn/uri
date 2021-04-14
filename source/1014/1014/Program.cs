using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            double l, consumo;

            km = int.Parse(Console.ReadLine());
            l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = km / l;

            Console.WriteLine(consumo.ToString("f3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
