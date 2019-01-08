using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Controller
{
    public class Input
    {
        private Game game;
        public Input(Game game)
        {
            this.game = game;
        }

        public void GameMove(System.ConsoleKey ch)
        {
              
        }

        public void MenuMove(System.ConsoleKey ch)
        {
            switch (ch)
            {
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
