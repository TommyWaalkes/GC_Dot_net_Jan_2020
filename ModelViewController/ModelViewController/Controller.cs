using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class Controller
    {
        public List<Person> PeopleDb { get; set; }
       
        public Controller()
        {
            PeopleDb = new List<Person>();
            PeopleDb.Add(new Person()
            {
                Name = "Tommy",
                Age = 28,
                IsADuckinDisguise = false,
                Job = "Teacher"
            });
            PeopleDb.Add(new Person()
            {
                Name = "Dr. Quackers",
                Age = 5,
                IsADuckinDisguise = true,
                Job = "Medical ductor"
            });
         
        }

        public void DisplayWelcome()
        {
            WelcomeView.DisplayWelcome();
        }

        public void DisplayPerson(Person p)
        {
            PersonView.DisplayPerson(p);
        }

        public void RegisterPerson()
        {
            Person newRegister = PersonView.RegisterPerson();
            PeopleDb.Add(newRegister);
        }

        public void DisplayAllNamesOfPeople()
        {
            for(int i = 0; i <PeopleDb.Count; i++)
            {
                PersonView.DisplayNameAndNum(i, PeopleDb[i]);
            }
            Console.WriteLine("Please select a person you want to learn about or input r to register a new person");

            string input = Console.ReadLine().Trim().ToLower();

            if(input == "r")
            {
                RegisterPerson();
            }
            else
            {
                int i = int.Parse(input);
                if(i> PeopleDb.Count - 1)
                {
                    ErrorView.PrintError($"The input index {i} is too high for a list of people with {PeopleDb.Count} entries");
                }
                else
                {
                    Person p = PeopleDb[i];
                    DisplayPerson(p);
                }
            }
        }
    }
}
