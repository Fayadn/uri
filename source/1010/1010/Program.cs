using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, np1, peca2, np2;
            double valor1, valor2, vf;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            peca1 = int.Parse(vet[0]);
            np1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet[0]);
            np2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vf = valor1*np1 + valor2*np2;

            Console.WriteLine("VALOR A PAGAR: R$ "+ vf.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
