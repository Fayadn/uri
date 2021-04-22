using System;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double percentual, reajuste, novoSalario;

            if (salario <= 400.00)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.00)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7.0;
            }
            else
            {

                percentual = 4.0;
            }

            reajuste = salario * percentual / 100.0;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo Salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("f0", CultureInfo.InvariantCulture) + " %");

        }
    }
}
