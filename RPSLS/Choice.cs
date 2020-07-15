using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Choice
    {
        string name;
        public string[] choices;

        public Choice()
        {
            choices = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
    }
}
