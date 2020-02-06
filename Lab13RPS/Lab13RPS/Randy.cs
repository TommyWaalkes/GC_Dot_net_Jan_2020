using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class Randy : Player
    {
        public Random r { get; set; }

        public Randy()
        {
            r = new Random();
        }

        public override RPS GetRPS()
        {
            int pick = r.Next(0, 3);
            RPS output = (RPS) pick;
            return output;
        }
    }
}
