using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Model
{
    public class Rockford : Drawable, ICharacter
    {
        public override Node Node { get; set; }

        public Rockford()
        {

        }

        //slaat eerst de nieuwe locatie op . 

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

        public override string ToString()
        {
            return "R";
        }
    }
}
