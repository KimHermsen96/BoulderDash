using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Controller
{
    public class Move
    {
        private Node Node { get; set; }

        public Move(Node node)
        {
            Node = node;
        }

        private void MoveTo(Node newLocation)
        {
            Node.Data = null;
            Node = newLocation;
            newLocation.Data = this;

        }

    
        public void MoveRight()
        {
            var rightLocation = Node.Right;
            MoveTo(rightLocation);
        }

        public void MoveLeft()
        {
            var leftLocation = Node.Left;
            MoveTo(leftLocation);
        }

        public void MoveUp()
        {
            var up = Node.Top;
            MoveTo(up);
        }

        public void MoveDown()
        {
            var down = Node.Bottom;
            MoveTo(down);
        }

    }
}
