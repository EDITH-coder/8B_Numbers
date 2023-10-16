using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8B_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkNumbers(5, 4));
            Console.WriteLine(checkNumbers(4,3));
            Console.WriteLine(checkNumbers(1, 4));
            Console.WriteLine(checkNumbers(20,15));
           

            Console.ReadLine();
        }

        public static bool checkNumbers(int num1, int num2) {
            //Compute the sum and Difference
            int sum = num1 + num2;
            int dif = num1 - num2;
            //Check if either is 5 or their sum or difference is 5.
            if (num1 ==5 || num2 == 5 || sum == 5 || dif == 5)
            {
                return true;
            }
            return false;
        }
    }
}
