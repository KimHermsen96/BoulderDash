using BoulderDash.Controller.Parser;
using BoulderDash.Model.NLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Controller
{
    public class Game
    {
        private ParseLevel parseLevel;
        public LinkedList linkedList { get; set; }

        public Game(MainController mainController)
        {
            parseLevel = new ParseLevel(mainController);
            parseLevel.ChooseLevel(1);
            parseLevel.Parse();
            linkedList = parseLevel.linkedList;
        }

        public void ChooseLevel(int lvl)
        {
            parseLevel.ChooseLevel(lvl);
            parseLevel.Parse();
        }


    }
}
