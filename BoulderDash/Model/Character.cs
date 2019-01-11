using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public abstract class Character : Model.Drawable
    {
        public virtual void MoveTo(Node newLocation)
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