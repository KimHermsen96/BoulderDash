using BoulderDash.Controller;
using BoulderDash.Model.NLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.View
{
    class Draw
    {
        private MainController mainController;

        public Draw(MainController mainController)
        {
            this.mainController = mainController;
        }

        public void Print()
        {
            Console.Clear();
            Node x = mainController.view.Board.Head;
            Node y = mainController.view.Board.Head;

            while (true)
            {
                if (y.Data == null)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(y.Data);
                }

                if (y.Right != null)
                {
                    y = y.Right;
                }
                else if (x.Bottom != null)
                {
                    Console.WriteLine();
                    y = x.Bottom;
                    x = y;
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
