using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller.Parser;
using BoulderDash.Model;
using BoulderDash.View;

namespace BoulderDash.Controller
{
    public class MainController
    {
        public Game game { get; set; }
        public ParseLevel Parser { get; set; }

        public MainController()
        {
            // in de parser word het veld geladen en de objecten aangemaakt. 
            this.Parser = new ParseLevel();
            this.game = Parser.ChooseLevel(1, this);

            bool x = true;
            game.PrintBoard();
            try
            {
                while (x)
                {
                    var key = Console.ReadKey(true).Key;
                    game.Move(key);
                    game.PrintBoard();
                }
            }
            catch (GameOverException e)
            {
                Console.WriteLine("Game Over");
                Console.Clear();
                game.PrintBoard();
                Console.ReadKey();
            }
        }

        
    }
}