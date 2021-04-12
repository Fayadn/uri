using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double AREA, π, RAIO;

                π = 3.14159;
            RAIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AREA = π * Math.Pow(RAIO,2);

            Console.WriteLine("A=" + AREA.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
