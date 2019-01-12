using BoulderDash.Controller.Parser;
using BoulderDash.Model.NLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;
using BoulderDash.Model.Interfaces;
using BoulderDash.View;

namespace BoulderDash.Controller
{
    public class Game
    {

        public Rockford Rockford { get; set; }
        public LinkedList LinkedList { get; set; }
        public List<IMovable> MovableObject { get; set; }

        public BoardView BoardView { get; set; }

        public Game()
        {
            MovableObject = new List<IMovable>();
            BoardView = new BoardView();
        }

        public void PrintBoard()
        {
            Console.Clear();
            BoardView.Print(LinkedList);
        }


        public void Move(ConsoleKey key)
        {
            MovableObject.ForEach(el => el.Move());
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Rockford.MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    Rockford.MoveDown();
                    break;
                case ConsoleKey.LeftArrow:
                    Rockford.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    Rockford.MoveRight();
                    break;
            }
        }


    }
}
