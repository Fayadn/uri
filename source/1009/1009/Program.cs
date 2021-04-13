using System;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
                        double vendas, salario, sf;

            nome = Console.ReadLine();
            sf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = sf + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
