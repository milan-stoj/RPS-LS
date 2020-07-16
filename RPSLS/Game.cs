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
            player1 = new Human("Player 1");
            player2 = SelectGameType();
            Console.Clear();
            RunGame(player1, player2);
        }


        public void RunGame(Player player1, Player player2)
        {
            string player1Choice;
            string player2Choice;
            while (player1.roundsWon < 2 && player2.roundsWon <2)
            {
                PrintScores(player1, player2);
                player1Choice = player1.SelectChoice(player1.name);
                player2Choice = player2.SelectChoice(player2.name);
                if (player1Choice == player2Choice)
                {
                    Console.Clear();
                    Console.WriteLine("Tie! Draw again");
                }
                else
                {
                    Console.Clear();
                    GetWinner(player1Choice, player2Choice).roundsWon++;
                }
            }
            PrintScores(player1, player2);
            if (player1.roundsWon == 2)
            {
                Console.WriteLine($"{player1.name} is the ultimate winner!");
            }
            else
            {
                Console.WriteLine($"{player2.name} is the ultimate winner!");
            }
            Console.ReadLine();
        }

        public Player SelectGameType()
        {
            Console.Clear();
            Console.Write("\n[1] vs Computer Game\n[2] vs Human Game\nSelect game type: ");
            while (true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        return new Computer();
                    case '2':
                        return new Human("Player 2");
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
            Console.WriteLine($"{player1.name} draws {player1Choice} and {player2.name} draws {player2Choice}");
            if (player1Choice == "Rock" && (player2Choice == "Scissors" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins!");
                return player1;
            }
            else if (player1Choice == "Paper" && (player2Choice == "Rock" || player2Choice == "Spock"))
            {
                Console.WriteLine($"{player1.name} wins!");
                return player1;
            }
            else if (player1Choice == "Scissors" && (player2Choice == "Paper" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins!");
                return player1;
            }
            else if (player1Choice == "Lizard" && (player2Choice == "Spock" || player2Choice == "Paper"))
            {
                Console.WriteLine($"{player1.name} wins!");
                return player1;
            }
            else if (player1Choice == "Spock" && (player2Choice == "Rock" || player2Choice == "Scissors"))
            {
                Console.WriteLine($"{player1.name} wins!");
                return player1;
            }
            else
            {
                Console.WriteLine($"{player2.name} wins!");
                return player2;
            } 
        }

        public void PrintScores(Player player1, Player player2)
        {
            Console.WriteLine($"{player1.name} Score: {player1.roundsWon}\n{player2.name}: {player2.roundsWon}");
        }
    }
}
