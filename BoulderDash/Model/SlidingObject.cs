using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public abstract class SlidingObject : Fallable , IMovable
    {
        public override void Move()
        {
            base.Move();
        }
    }
}