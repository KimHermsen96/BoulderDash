using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.PrintLevel(1);

            Controller.Parser.ParseLevel levelParser = new Controller.Parser.ParseLevel();
            levelParser.ChooseLevel(1);
            levelParser.Parse();
            levelParser.readParse();
            Console.ReadKey();
        }
    }
}
