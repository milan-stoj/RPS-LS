using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {
            name = GetName();
            roundsWon = 0;
        }

        public string GetName()
        {
            Console.Write("\nEnter name for Player 1: ");
            return Console.ReadLine();
        }

        public override string SelectChoice()
        {
            Console.Write("\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock");
            Console.Write("\nSelect your draw!: ");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return possibleChoices.choices[0];
                    case "2":
                        return possibleChoices.choices[1];
                    case "3":
                        return possibleChoices.choices[2];
                    case "4":
                        return possibleChoices.choices[3];
                    case "5":
                        return possibleChoices.choices[4];
                    default:
                        Console.Write("\n| Invalid Selection | ");
                        Console.Write("\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock");
                        Console.Write("\nSelect your draw!: ");
                        break;
                }
            }
        }
    }
}
