using System;
using System.Globalization;
using ProblemaExemplo02._1;

namespace ProblemaExemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.InvariantCulture;
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];
            for (int i = 0;i<n;i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), cultura);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for(int i = 0;i<n;i++)
            {
                soma += vect[i].Preco;
            }
            double media = soma/n;
            Console.WriteLine("A MÉDIA DE PREÇOS É: "+ media.ToString("f2", cultura));

        }
    }
}


