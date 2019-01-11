using BoulderDash.Controller;
using BoulderDash.Model.NLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.View
{
   public class BoardView
    {
        public void Print(LinkedList linkedList)
        {
            Node x = linkedList.Head;
            Node y = linkedList.Head;
            string stringOutput = "";
            while (true)
            {
                if (y.Data == null)
                {
                    stringOutput += " ";
                }
                else
                {
                    stringOutput += y.Data;
                }

                if (y.Right != null)
                {
                    y = y.Right;
                }
                else if (x.Bottom != null)
                {
                    stringOutput += "\n";
                    y = x.Bottom;
                    x = y;
                }
                else
                {
                    break;
                }
            }
            Console.Write(stringOutput);
        }
    }
}
