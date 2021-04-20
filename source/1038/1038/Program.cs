using System;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd, c;
            double total;

            string[] vet = Console.ReadLine().Split(' ');
            c = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            if (c == 1)
            {
                total = (double)4.00 * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (c == 2)
            {
                total = (double)4.50 * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (c == 3)
            {
                total = (double)5.00 * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (c == 4)
            {
                total = (double)2.00 * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (c == 5)
            {
                total = (double)1.50 * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
