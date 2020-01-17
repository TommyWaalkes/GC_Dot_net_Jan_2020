using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Welcome to our Calculator");

                Console.WriteLine("Please Enter a Length");
                string l = Console.ReadLine();
                double length = double.Parse(l);

                Console.WriteLine("Please Enter a Width");
                string w = Console.ReadLine();
                double width = double.Parse(w);

                double perimeter = GetPerimeter(length, width);
                double area = GetArea(length, width);

                Console.WriteLine("The perimeter is: " + perimeter);
                Console.WriteLine("The Area is: " + area);

                string response = "";
                goOn = ContinueLoop();
                //while (response != "y" || response != "n")
                //{
                //    Console.WriteLine("Would you like to continue? Y/N");
                //    response = Console.ReadLine();

                //    if (response.ToLower() == "y")
                //    {
                //        break;
                //    }
                //    else if (response.ToLower() == "n")
                //    {
                //        goOn = false;
                //        break;
                //    }
                //}

            }
        }

        public static double GetPerimeter(double length, double width)
        {
            double perimeter = (2 * length) + (2 * width);
            return perimeter;
        }

        public static double GetArea(double length, double width)
        {
            return length * width;
        }

        public static bool ContinueLoop()
        {
            Console.WriteLine("Would you like to input another room? y/n");
            string response = Console.ReadLine().ToLower().Trim();

            if(response == "y")
            {
                return true;
            }
            else if(response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Hey I didn't understand that let's try again.");
                return ContinueLoop();
            }
        }
    }
}
