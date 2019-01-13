using BoulderDash.Model.AbstractClasses;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model.AbstractClasses

{
    public abstract class SlidingObject : Fallable 
    {
        public override void Move()
        {

            if (Node.Bottom.Right.Data == null && Node.Right.Data == null && Node.Bottom.Data is SlidingObject)
            {
                Node.Bottom.Right.Data = this;
                Node.Data = null;
                Node = this.Node.Bottom.Right;
            }

            if (Node.Bottom.Left.Data == null && Node.Left.Data == null && Node.Bottom.Data is SlidingObject)
            {
                Node.Bottom.Left.Data = this;
                Node.Data = null;
                Node = this.Node.Bottom.Left;
            }
            base.Move();
        }
    }
}