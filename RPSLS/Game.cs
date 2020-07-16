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
            while (true)
            {
                player1.SelectChoice();
            }
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
    }
}
