using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name;
        public int roundsWon;
        public Choice possibleChoices;

        public Player()
        {
            possibleChoices = new Choice();
        }

        public abstract string SelectChoice();

    }
}
