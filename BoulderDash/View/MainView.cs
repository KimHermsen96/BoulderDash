using BoulderDash.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.View
{
    class MainView
    {
        public BoardView Board { get; private set; }

        public MainView()
        {
            Board = new BoardView();
        }
    }
}
