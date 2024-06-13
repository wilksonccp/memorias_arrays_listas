using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ExercicioParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 6);
            int s2 = Calculator.Sum(2, 6, 25);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
    internal class Calculator
    {
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

    }
}


