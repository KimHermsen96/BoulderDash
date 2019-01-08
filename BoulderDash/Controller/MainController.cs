using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller.Parser;

namespace BoulderDash.Controller
{
    public class MainController
    {
        public Model.MainModel mainModel { get; set; }
        public View view;
        public Input input;
        private Game game;

        public MainController()
        {
            mainModel = new Model.MainModel();
            game = new Game(this);
            view = new View()
            {
                Board = game.linkedList
            };
            input = new Input(game);
        }
    }
}
