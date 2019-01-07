using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Model
{
    public class Rockford : ICharacter, IDrawable
    {
        public Node Node { get; set; }

        public Rockford()
        {

        }

        public void GetPosition()
        {
        }

        public void MoveRight()
        {
            var rightLocation = Node.Right;
            MoveTo(rightLocation);

        }

        private void MoveTo(Node rightLocation)
        {
            Node.Data = null;
            Node = rightLocation;
            rightLocation.Data = this;
        }

        public void MoveLeft()
        {
            var rightLocation = Node.Left;
            MoveTo(rightLocation);
        }

        public void MoveUp()
        {
            var rightLocation = Node.Top;
            MoveTo(rightLocation);
        }

        public void MoveDown()
        {
            var rightLocation = Node.Bottom;
            MoveTo(rightLocation);
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
