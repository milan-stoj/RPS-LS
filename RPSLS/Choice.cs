using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Choice
    {
        public List<string> choices;
        

        public Choice()
        {
            choices = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
    }
}
