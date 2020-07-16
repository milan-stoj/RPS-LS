using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player player1;
        public Player player2;

        public Game()
        {
            player1 = new Human();
            player2 = SelectGameType();
            RunGame(player1, player2);
        }

        public void RunGame(Player player1, Player player2)
        {
            while (player1.roundsWon < 2 && player2.roundsWon <2)
            {
                string player1choice = player1.SelectChoice();
                string player2choice = player2.SelectChoice();
                if (player1choice == player2choice)
                {
                    Console.WriteLine("Tie! Draw again");
                }
                else
                {
                    GetWinner(player1choice, player2choice).roundsWon++;
                }
            }
            Console.ReadLine();
        }

        public Player SelectGameType()
        {
            Console.Clear();
            Console.Write("\n[1] vs Computer Game\n[2] vs Human Game\nSelect game type: ");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return new Computer();
                    case "2":
                        return new Human();
                    default:
                        Console.Clear();
                        Console.Write("\n| Invalid Selection | ");
                        Console.Write("\n[1] vs Computer Game\n[2] vs Human Game\nTry again: ");
                        break;
                }
            }
        }

        public Player GetWinner(string player1Choice, string player2Choice)
        {
            Console.WriteLine($"Player 1 draws {player1Choice} and Player 2 draws {player2Choice}: \n");
            if (player1Choice == "Rock" && (player2Choice == "Scissors" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"Player 1 wins!");
                return player1;
            }
            else if (player1Choice == "Paper" && (player2Choice == "Rock" || player2Choice == "Spock"))
            {
                Console.WriteLine($"Player 1 wins!");
                return player1;
            }
            else if (player1Choice == "Scissors" && (player2Choice == "Paper" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"Player 1 wins!");
                return player1;
            }
            else if (player1Choice == "Lizard" && (player2Choice == "Spock" || player2Choice == "Paper"))
            {
                Console.WriteLine($"Player 1 wins!");
                return player1;
            }
            else if (player1Choice == "Spock" && (player2Choice == "Rock" || player2Choice == "Scissors"))
            {
                Console.WriteLine($"Player 1 wins!");
                return player1;
            }
            else
            {
                Console.WriteLine($"Player 2 wins!");
                return player2;
            } 
        }
    }
}
