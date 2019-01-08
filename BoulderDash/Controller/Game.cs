using BoulderDash.Controller.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Controller
{
    class Game
    {
        private ParseLevel parseLevel;

        public Game(MainController mainController)
        {
            parseLevel = new ParseLevel();
            parseLevel.ChooseLevel(1);
            parseLevel.Parse();
        }


    }
}
