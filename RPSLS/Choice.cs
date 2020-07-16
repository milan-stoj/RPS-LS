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

        public string Rock()
        {
            return @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
        }
        public string Paper()
        {
            return @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
";
        }
        public string Scissors()
        {
            return @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";
        }
        public string Lizard()
        {
            return @"
      __  ,
      (' \ \
       \ \\/ 
     '\/\ \\
         \ \\/\,
          \ \\
          /\ \\
          \ `\\\
          '   `\\
                \\
                 \\
                  \\    ,
                   `---'  
";
        }

        public string Spock()
        {
            return @"
              ,                          
     __  _.-'` `'-.                      
    /||\'._ __{}_(  
    ||||  |'--.__\ 
    |  L.(   ^_\^                        
    \ .-' |   _ |                        
    | |   )\___/                         
    |  \-'`:._]                          
    \__/;      '-.                       
    |   |o     __ \                      
    |   |o     )( |                      
    |   |o     \/ \                      
                        ";
        }



    }
}
