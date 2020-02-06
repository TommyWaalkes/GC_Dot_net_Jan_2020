using System;

namespace Lab13RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocky r = new Rocky();
            //Console.WriteLine(r.GetRPS());

            // Human h = new Human();
            //Console.WriteLine(h.GetRPS());
            int paperCount = 0, scissorsCount = 0, rockCount = 0;
            Randy rando = new Randy();
            for(int i = 0; i < 20; i++)
            {
                RPS input = rando.GetRPS();
                if (input == RPS.paper)
                {
                    paperCount++;
                }
                else if (input == RPS.rock)
                {
                    rockCount++;
                }
                else if (input == RPS.scissors)
                {
                    scissorsCount++;
                }
            }

            Console.WriteLine("Paper Count: " + paperCount);
            Console.WriteLine("Scissors Count: " +scissorsCount);
            Console.WriteLine("Rock Count: " + rockCount);
        }
    }
}
