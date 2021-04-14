using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n100, n50, n20, n10, n5, n2, n1,resto100,resto50,resto20,resto10,resto5,resto2;

            x = int.Parse(Console.ReadLine());

            n100 = x / 100;
            resto100 = x % 100;
            n50 = resto100 / 50;
            resto50 = resto100 % 50;
            n20 = resto50 / 20;
            resto20 = resto50 % 20;
            n10 = resto20 / 10;
            resto10 = resto20 % 10;
            n5 = resto10 / 5;
            resto5 = resto10 % 5;
            n2 = resto5 / 2;
            resto2 = resto5 % 2;
            n1 = resto2 / 1;

            Console.WriteLine(x);
            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");

        }
    }
}
