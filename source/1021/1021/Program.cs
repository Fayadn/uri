using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, n100, n50, n20, n10, n5, n2, resto100, resto50, resto20, resto10, resto5, resto2,
                m1, m50, m25, m10, m5, m01, rm1, rm50, rm25, rm10, rm5;


            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            n100 = (int) x / 100;
            resto100 = x % 100;
            n50 = (int) resto100 / 50;
            resto50 = resto100 % 50;
            n20 = (int)resto50 / 20;
            resto20 = resto50 % 20;
            n10 = (int)resto20 / 10;
            resto10 = resto20 % 10;
            n5 = (int)resto10 / 5;
            resto5 = resto10 % 5;
            n2 = (int)resto5 / 2;
            resto2 = resto5 % 2;

            m1 = resto2 / 1;
            rm1 = resto2 % 1;
            m50 = rm1 / 0.50;
            rm50 = rm1 % 0.50;
            m25 = rm50 / 0.25;
            rm25 = rm50 % 0.25;
            m10 = rm25 / 0.10;
            rm10 = rm25 % 0.10;
            m5 = rm10 / 0.05;
            rm5 = rm10 % 0.05;
            m01 = rm5 / 0.01;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)m1 + " moeda (s) de R$ 1.00");
            Console.WriteLine((int)m50 + " moeda (s) de R$ 0.50");
            Console.WriteLine((int)m25 + " moeda (s) de R$ 0.25");
            Console.WriteLine((int)m10 + " moeda (s) de R$ 0.10");
            Console.WriteLine((int)m5 + " moeda (s) de R$ 0.05");
            Console.WriteLine((int)m01 + " moeda (s) de R$ 0.01");

        }
    }
}
