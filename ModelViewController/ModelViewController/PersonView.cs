using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class PersonView
    {
        public static void DisplayPerson(Person p)
        {
            Console.WriteLine("Name: "+p.Name);
            Console.WriteLine("Age: "+p.Age);
            Console.WriteLine("Job: "+ p.Job);
            Console.WriteLine("Is a Duck in Disguise: " +p.IsADuckinDisguise);
        }

        public static Person RegisterPerson()
        {
            Console.WriteLine("Hello, we are registering a new person and need to collect their info");
            Console.WriteLine("Please input a name");
            Person p = new Person();
            p.Name = Console.ReadLine();
            Console.WriteLine("Next please input a name");
            p.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Next please input a Job");
            p.Job = Console.ReadLine();
            Console.WriteLine("Lastly, are you a duck posing as a person? true or fasle");
            p.IsADuckinDisguise = bool.Parse(Console.ReadLine());

            return p;
        }

        public static void DisplayNameAndNum(int i, Person p)
        {
            Console.WriteLine($"{i} {p.Name}");
        }
    }
}
