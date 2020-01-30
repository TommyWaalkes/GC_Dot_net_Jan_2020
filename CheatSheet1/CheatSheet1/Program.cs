using System;
using System.Collections.Generic;

namespace CheatSheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Array();
        }

        //Loops use: 


        //Loops use: conditionals to repeat segments of code so code doesn't have to be written over and over again.

        public static void Loops()

        {
            int iterations;

            Console.WriteLine("This is a for loop. How many times would you like to iterate the loop? (input an int)");

            iterations = int.Parse(Console.ReadLine());

            //"int i = 0; i < variable/constant, i++" is the standard "for loop" condtional. very important to memorize.

            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine("This is iteration number " + i + ".");
            }

            Console.WriteLine("Would you like to try a while loop? (yes/no)");

            string response = Console.ReadLine();

            if (response == "yes")
            {
                bool loop = true;

                while (loop)
                {
                    Console.WriteLine("This loop continues forever. Would you like to stop? (yes/no)");

                    string stop = Console.ReadLine();

                    if (stop == "yes")
                    {
                        loop = false;
                    }
                }
                Console.WriteLine("The loop has ended.");
            }
        }


        //If Statements/Switch Use: 
        public void IfSwitch()
        {
            //if statements are used to test to see if a particular statement is true and executes a line of code based on the result
            int x = 5;

            if (x > 4)
            {
                Console.WriteLine("123");
            }
            else if (x < 3)
            {
                Console.WriteLine("456");
            }
            else
            {
                Console.WriteLine("789");
            }
   //Similar to if/else statements. Switch statements are typically used when there are five or more statements you are testing.

            Console.WriteLine("Enter a number 1-6");

            string y = Console.ReadLine();

            int b = int.Parse(y);

            switch (b)
            {
                case 1: Console.WriteLine("a"); break;

                case 2: Console.WriteLine("b"); break;

                case 3: Console.WriteLine("c"); break;

                case 4: Console.WriteLine("d"); break;

                case 5: Console.WriteLine("e"); break;

                case 6: Console.WriteLine("f"); break;
            }
        }

        /*
        - Methods are a sequence of instructions, that perform a specific task, which are packaged as one unit.
        - Found in this sort of format:
        public static [varType] [methodName]
        {
         //Do things
        }
        - There are also premade methods used in C#, some of these are.
        Console.ReadLine(), Console.WriteLine(), ToUpper(), ToLower(), ToList() ... etc.
        - Methods must always *return* something for the  method to function.
        (For bools, must at least return true, false, or another method, same for ints and strings)
        -To call a method, you must ask for [methodName]()
         */
        public bool Method()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                Console.WriteLine("Thank you, we will now restart.");
                return Method();
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you for participating.");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, that was not a valid response.");
                return Method();
            }
        }


        //Lists Use: 
        public void List()
        {
            //A list can hole one of any data type including arrays and objects.
            //lists are mutable meaning they can change in length, unlike arrays.
            List<string> numbers = new List<string>
            {
                "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"
            };

            //the Add() method allows a value to be appended to a List.          
            numbers.Add("Eleven");

            foreach (string i in numbers)
            {
                Console.WriteLine(i);
            }

            List<int[]> numberArrays = new List<int[]>
            {
                new int[]{1,2,3},
                new int[]{4,5,6},
                new int[]{7,8,9},
            };

            for (int i = 0; i < numberArrays.Count; i++)
            {
                for (int j = 0; j < numberArrays[i].Length; j++)
                {
                    Console.Write(numberArrays[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }


        //Array Use: Arrays store multiple pieces of data in one place. Arrays are used 
        //when you need to lots of info at once EG say a guest list for a party. Arrays 
        //Can't shrink or grow in spaces. They always start at index of 0
        public static void Array()
        {
            int[] nums = new int[5];
            nums[0] = 100;
            nums[1] = 100;
            nums[2] = 100;
            nums[3] = 200;
            nums[4] = 200;
            
            //Double Each number 
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] *= 2;
            }

            int total = 0;
            //Take the average of all the numbers
            foreach(int num in nums)
            {
                total += num;
            }

            int average = total / nums.Length;
            Console.WriteLine(average);
        }

    }
}
