using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,t;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (b-a <= 0)
            {
                t = b - a + 24;
            }
            else
            {
                t = b - a;
            }

            Console.WriteLine("O JOGO DUROU " + t + " HORA(S)");


        }
    }
}
