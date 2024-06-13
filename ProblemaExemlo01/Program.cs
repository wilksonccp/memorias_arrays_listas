using System;
using System.Globalization;

namespace ProblemaExemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.InvariantCulture;
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0;i<n;i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), cultura);
            }
            double soma = 0.0;
            for (int i = 0;i<n;i++)
            {
                soma += vect[i];
            }
            double media = soma/n;
            Console.WriteLine("A ALTURA MÉDIA É: " + media.ToString("F2", cultura));
        }
    }
}


