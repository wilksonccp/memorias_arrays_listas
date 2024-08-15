using System;
using System.Globalization;

namespace ExercicioDeFicacao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guests[] rooms = new Guests[10];

            int rentQtd = 1;
            Console.WriteLine("Quantos hospedes serão alocados?");
            int gusQtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < gusQtd; i++)
            {
                Console.WriteLine("Aluguel: #" + rentQtd);
                Console.Write("Nome: ");
                string nameGues = Console.ReadLine();
                Console.Write("Email: ");
                string emailGues = Console.ReadLine();
                Console.Write("Quarto: ");
                int roomGues = int.Parse(Console.ReadLine());

                rentQtd++;
            }
            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }
        }
    }
    internal class Guests()
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Guests(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}


