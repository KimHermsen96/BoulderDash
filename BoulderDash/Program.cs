using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;

namespace BoulderDash
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller.Parser.ParseLevel levelParser = new Controller.Parser.ParseLevel();
            levelParser.ChooseLevel(2);
            levelParser.Parse();
            levelParser.Print();
            var levelParserRockford = levelParser.Rockford;

            bool x = true;
            while (x)
            {
                var ch = Console.ReadKey(false).Key;

                switch (ch)
                {
                    case ConsoleKey.UpArrow:
                        levelParserRockford.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        levelParserRockford.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        levelParserRockford.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                       levelParserRockford.MoveRight();
                        break;

                }
                Console.Clear();
                levelParser.Print();
            }
            Console.ReadKey();
        }
    }
}
