﻿using System;
using System.Globalization;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo, pi;
            string[] vet;

            pi = 3.14159;

            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2;
            circulo = pi * Math.Pow(c, 2);
            trapezio = (a + b) * c / 2;
            quadrado = Math.Pow(b,2);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
