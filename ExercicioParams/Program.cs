using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ExercicioParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int result = Calculator.Sum(new int[]{8,6,5});
            int result01 = Calculator.Sum(new int[]{8,3,5,8});
            Console.WriteLine("Resultado n3: "+ result);
            Console.WriteLine("Resultado n4: "+ result01);
            /*int result = Calculator.Sum( 30, 45, 89 );
            Console.WriteLine(result);*/
        }
    }
    internal class Calculator
    {
        public static int Sum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}


