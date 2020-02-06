using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override RPS GetRPS()
        {
            return RPS.rock;
        }
    }
}
