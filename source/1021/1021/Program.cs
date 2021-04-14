using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int qtd, resto, nota, moeda;


            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(N * 100 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            qtd = resto / (nota * 100);
            Console.WriteLine(qtd + " nota(s) de R$ "+ nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            qtd = resto / (nota * 100);
            Console.WriteLine(qtd + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            qtd = resto / (nota * 100);
            Console.WriteLine(qtd + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            qtd = resto / (nota * 100);
            Console.WriteLine(qtd + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            qtd = resto / (nota * 100);
            Console.WriteLine(qtd + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            qtd = resto / (nota * 100);
            Console.WriteLine(qtd + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            qtd = resto / (moeda);
            Console.WriteLine(qtd + " moeda(s) de R$ 1.00");
            resto = resto % (moeda);

            moeda = 50;
            qtd = resto / (moeda);
            Console.WriteLine(qtd + " moeda(s) de R$ 0.50");
            resto = resto % (moeda);

            moeda = 25;
            qtd = resto / (moeda);
            Console.WriteLine(qtd + " moeda(s) de R$ 0.25");
            resto = resto % (moeda);

            moeda = 10;
            qtd = resto / (moeda);
            Console.WriteLine(qtd + " moeda(s) de R$ 0.10");
            resto = resto % (moeda);

            moeda = 5;
            qtd = resto / (moeda);
            Console.WriteLine(qtd + " moeda(s) de R$ 0.05");
            resto = resto % (moeda);

            moeda = 1;
            qtd = resto / (moeda);
            Console.WriteLine(qtd + " moeda(s) de R$ 0.01");


        }
    }
}
