using System;
using System.Globalization;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada < 0 || entrada > 100) {
                Console.WriteLine("Fora de Intervalo");
            }
            else if (entrada <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (entrada <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (entrada <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
