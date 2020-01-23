using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Casino, how many sides do you want your dice to have?");
            string input = Console.ReadLine();
            int sides = int.Parse(input);


                Random r = new Random();
                Random r2 = new Random();

            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("Num 1: "+ RollDice(1,sides));
                Console.WriteLine("Num 2: "+ RollDice(1,sides));
            }
        }

        public static int RollDice(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max + 1);
        }
    }
}
