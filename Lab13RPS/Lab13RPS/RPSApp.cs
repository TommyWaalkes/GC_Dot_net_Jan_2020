using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class RPSApp
    {
        Player Player1 { get; set; }
        Player Player2 { get; set; }

        public RPSApp()
        {
            Player1 = new Human();
            while (true)
            {
                Console.WriteLine("Please select an opponent: Rocky or Randy");
                string input = Console.ReadLine().ToLower().Trim();

                if (input == "rocky")
                {
                    Player2 = new Rocky();
                    break;
                }
                else if (input == "randy")
                {
                    Player2 = new Randy();
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that let's try again.");
                }
            }

            Play();
        }

        public void Play()
        {
            Console.WriteLine("Users turn");
            RPS p1throw = Player1.GetRPS();

            Console.WriteLine("Opponents turn");
            RPS p2throw = Player2.GetRPS();
            Console.WriteLine(p2throw);
            DecideWinner((int)p1throw, (int)p2throw);
            while (true)
            {
                Console.WriteLine("Would you like to play again? Y/N");
                string input = Console.ReadLine().ToLower().Trim();

                if(input == "y")
                {
                    Play();
                    break;
                }
                else if(input == "n")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, lets try again");
                }
            }
        }



        public void DecideWinner(int p1Throw, int p2Throw)
        {
            int[,] array2D = new int[3, 3] { { 0, -1, 1 }, { 1, 0, -1 }, { -1, 1, 0 } };
            int result = array2D[p1Throw, p2Throw];

            if (result == 0)
            {
                Console.WriteLine("It was a draw!");
            }
            else if (result == 1)
            {
                Console.WriteLine("You win!");
            }

            else
            {
                Console.WriteLine($"{Player2.Name} wins!");
            }
        }


    }
}
