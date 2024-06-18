using System;
using System.ComponentModel;
using System.Globalization;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interactions all = new Interactions();
            string inicio = all.Inicial();
            string inicioErro = all.InicialError();
            Console.WriteLine(inicio);
            int calcKind = int.Parse(Console.ReadLine());
            while (calcKind > 4 && calcKind < 1)
            {
                Console.WriteLine(inicioErro);
                calcKind = int.Parse(Console.ReadLine());
            }
            string operation = " ";
            if (calcKind == 1)
            {
                operation = "somados";
            }
            else if (calcKind == 2)
            {
                operation = "subitraidos";
            }
            else if (calcKind == 3)
            {
                operation = "multiplicados";
            }
            else
            {
                operation = "divididos";
            }
            Console.WriteLine($"Insira os números que deverão ser {operation}.");


        }
    }
    internal class Interactions
    {
        public string Inicial()
        {
            return "Que tipo de calculo vamos fazer hoje?\n" +
            "Insira os números conforme sua escolha.\n" +
            " 1 - para soma\n" +
            " 2 - para subtração\n" +
            " 3 - para multiplicação\n" +
            " 4 - para divisão\n";
        }
        public string InicialError()
        {
            return "Por gentileza escolha somente entre as opções existentes\n" +
            "Insira os números conforme sua escolha.\n" +
            " 1 - para soma\n" +
            " 2 - para subtração\n" +
            " 3 - para multiplicação\n" +
            " 4 - para divisão\n";
        }
    }
}


