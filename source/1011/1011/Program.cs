using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, R, volume;

            pi = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("f3",CultureInfo.InvariantCulture));

        }
    }
}
