using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Title title = new Title();
                Console.WriteLine(title.titleText);
                Console.ReadKey();
                Console.Clear();
                Game newGame = new Game();
                Console.WriteLine("Press enter to play again!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
