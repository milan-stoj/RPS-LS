using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        Random rand;

        public Computer()
        {
            name = "Deep Blue";
            rand = new Random();
            roundsWon = 0;
        }

        public override string SelectChoice()
        {
            return possibleChoices.choices[rand.Next(possibleChoices.choices.Count()-1)];
        }
    }
}
