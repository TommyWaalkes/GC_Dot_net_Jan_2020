using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SetupFactorial(20));
        }

        public static int SetupFactorial(int num)
        {
           return RecurFactorial(num, 1);
        }

        public static int RecurFactorial(int num, int total)
        {
            total *= num;
            num--;
            if (num <= 1)
            {
                return total;
            }
            else
            {
                return RecurFactorial(num, total);
            }
        }
    }
}
