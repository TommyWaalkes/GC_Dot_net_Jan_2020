using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
     abstract class Player
    {
        public string Name { get; set; }

        public virtual RPS GetRPS()
        {
            throw new NotImplementedException();
        }
    }

    public enum RPS
    {
        rock,
        paper,
        scissors
    }

}
