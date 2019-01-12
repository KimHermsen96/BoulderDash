using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public abstract class SlidingObject : Fallable , IMovable
    {
        public override void Move()
        {
            if (Node.Bottom.Right.Data == null && Node.Right.Data == null)
            {
                Node.Bottom.Right.Data = this;
                Node.Data = null;
                Node = this.Node.Bottom.Right;
            }

            if (Node.Bottom.Left.Data == null && Node.Left.Data == null)
            {
                Node.Bottom.Left.Data = this;
                Node.Data = null;
                Node = this.Node.Bottom.Left;
            }
            base.Move();
        }
    }
}