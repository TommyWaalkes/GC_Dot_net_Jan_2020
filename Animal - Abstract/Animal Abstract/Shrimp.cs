using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class Shrimp : Animal
    {
        public Shrimp()
        {
            base.name = "Craig the Shrimp";
        }
        public override string GetFood()
        {
            return "Plant matter and dead fish";
        }
        public override string MakeSound()
        {
            return "snapping sounds";
        }

    }
}
