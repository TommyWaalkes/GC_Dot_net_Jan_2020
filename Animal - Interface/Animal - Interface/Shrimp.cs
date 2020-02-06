using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Shrimp : IAnimal
    {
        public string GetFood()
        {
            return "Dead Fish and Plants";
        }

        public string MakeSound()
        {
            return "Snap snap";
        }

        public override string ToString()
        {
            return "the shrimp goes " + MakeSound() + ". The Shrimp eats " + GetFood();
        }
    }
}
