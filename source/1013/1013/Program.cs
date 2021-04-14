using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior1, maior2;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maior1 = (a + b + Math.Abs(a - b)) / 2;
            maior2 = (maior1 + c + Math.Abs(maior1 - c)) / 2;

            Console.WriteLine(maior2 + " eh o maior");
        }
    }
}
