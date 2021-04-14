using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {

            int inicio, termino, hi, mi, si, ht, mt, st, dia, hora, minuto, segundo, duracao;
            string[] vet;

           Console.Write("Dia "); inicio = int.Parse(Console.ReadLine());
            vet = Console.ReadLine().Split(' ');
            hi = int.Parse(vet[0]);
            mi = int.Parse(vet[2]);
            si = int.Parse(vet[4]);

            Console.Write("Dia "); termino = int.Parse(Console.ReadLine());
            vet = Console.ReadLine().Split(' ');
            ht = int.Parse(vet[0]);
            mt = int.Parse(vet[2]);
            st = int.Parse(vet[4]);

            inicio = inicio * 24 * 60 * 60 + hi * 60 * 60 + mi * 60 + si;
            termino = termino * 24 * 60 * 60 + ht * 60 * 60 + mt * 60 + st;

            duracao = termino - inicio;

            dia = duracao / (24 * 60 * 60);
            segundo = duracao % (24 * 60 * 60);
            hora = segundo / (60 * 60);
            segundo = segundo % (60 * 60);
            minuto = segundo / 60;
            segundo = segundo % 60;

            Console.WriteLine(dia + " dia(s)");
            Console.WriteLine(hora + " hora(s)");
            Console.WriteLine(minuto + " minuto(s)");
            Console.WriteLine(segundo + " segundo(s)");




        }
    }
}
