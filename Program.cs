using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_intergers_to_return_true_if_5_or_diff_is_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer values:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool result = CheckIfFive(num1, num2);

            Console.WriteLine("Result: " + result);
        }

        static bool CheckIfFive(int num1, int num2)
        {
            return (num1 == 5 || num2 == 5 || num1 + num2 == 5 || Math.Abs(num1 - num2) == 5);

        }
    }
}
