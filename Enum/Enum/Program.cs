using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OrderSize.SuperSize);
            //Enum.GetValues(typeof(SpeciesEnum)).Length;
            //int animalNumber = (int)Enum.Parse(typeof(OrderSize), "Dog");
            int index = (int)OrderSize.Large;
            Console.WriteLine(index);
        }
    }

    public enum WeekDays
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum OrderSize
    {
        Small, 
        Medium, 
        Large, 
        SuperSize
    }
}
