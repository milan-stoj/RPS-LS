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
        // public List<string> choiceImage;

        public Choice()
        {
            choices = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            /*choiceGraphic = new List<string>()
            {
                @"
            
                _______
            ---'   ____)
                  (_____)
           ROCK   (_____)
                  (____)
            ---.__(___)
            ",
                @"
                 _______
            ---'    ____)____
                       ______)
           PAPER      _______)
                     _______)
            ---.__________)
            ",
                @"
                _______
            ---'   ____)____
                      ______)
          SCISSORS__________)
                  (____)
            ---.__(___)
            ",

                @"
                 __  ,
                 (' \ \
                  \ \\/ 
                '\/\ \\
                    \ \\/\,
                     \ \\
           LIZARD    /\ \\
                     \ `\\\
                     '   `\\
                           \\    ,
                            `---' 
            ",
                @"
                        ,                          
               __  _.-'` `'-.                      
              /||\'._ __{}_(  
              ||||  |'--.__\ 
              |  L.(   ^_\^                        
              \ .-' |   _ |                        
       SPOCK  | |   )\___/                         
              |  \-'`:._]                          
              \__/;      '-.                       
              |   |o     __ \                      
              |   |o     )( |                      
              |   |o     \/ \                      
                                  "
            };*/
        }
    }
}
