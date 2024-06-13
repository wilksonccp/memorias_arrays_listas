using System;
using System.Globalization;
using ExerrcicioFixacao;

namespace ExercicioFicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quandos quartos você deseja alugar? ");
            int alugueis = int.Parse(Console.ReadLine());

            Alugueis[] novatemporada = new Alugueis[10];
            for (int i = 0; i < alugueis; i++)
            {
                Console.Write("Aluguel: ");
                int aluguel = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                novatemporada[quarto] = new Alugueis { Aluguel = aluguel, Nome = nome, Email = email, Quarto = quarto };
            }
            for (int i = 0; i < 10; i++)
            {
                if (novatemporada[i] != null)
                {
                    Console.WriteLine($"{novatemporada[i].Quarto}: {novatemporada[i].Nome}, {novatemporada[i].Email}");
                }
            }
            Console.WriteLine("======================================================================");
            foreach (var aluguel in novatemporada)
            {
                if (aluguel != null)
                {
                    Console.WriteLine($"{aluguel.Quarto}: {aluguel.Nome}, {aluguel.Email}");
                }
            }
        }
    }

    public class Alugueis
    {
        public int Aluguel { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}


