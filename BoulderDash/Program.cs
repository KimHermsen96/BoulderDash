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
            //Game game = new Game();
            //game.PrintLevel(1);

            Controller.Parser.ParseLevel levelParser = new Controller.Parser.ParseLevel();
            levelParser.ChooseLevel(1);
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
            //          }  Rockford r = new Rockford(levelParser.linkedList);
            //            r.Move();


            Console.ReadKey();


        }
    }
}
