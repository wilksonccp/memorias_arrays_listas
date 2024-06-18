using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ExercicioParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int result = Calculator.Sum(8,3,5);
            Console.WriteLine("Resultado: ", result);
            /*int result = Calculator.Sum( 30, 45, 89 );
            Console.WriteLine(result);*/
        }
    }
    internal class Calculator
    {
        public static int Sum(int n1, int n2)
        {
            return (n1 + n2);
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3);
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return (n1 + n2 + n3 + n4);
        }

        /*public static int Sum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }*/
    }
}


