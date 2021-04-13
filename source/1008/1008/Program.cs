using System;
using System.Globalization;

namespace _1008 
{
    class Program
    {
        static void Main(string[] args)
        {
            int NH, NUMBER;
            double VR, SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            NH = int.Parse(Console.ReadLine());
            VR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = NH * VR;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("f2",CultureInfo.InvariantCulture));


        }
    }
}
