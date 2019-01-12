using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller.Parser;
using BoulderDash.View;

namespace BoulderDash.Controller
{
    public class MainController
    {
        private Game game;
        public ParseLevel Parser { get; set; }

        public MainController()
        {
            // in de parser word het veld geladen en de objecten aangemaakt. 
            Parser = new ParseLevel();
            var game = Parser.ChooseLevel(3);
            
            bool x = true;
            game.PrintBoard();
            while (x)
            {
                var key = Console.ReadKey(true).Key;
                game.Move(key);
                game.PrintBoard();
            }
        }
    }
}
