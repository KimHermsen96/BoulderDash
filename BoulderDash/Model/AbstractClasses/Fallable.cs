using System;
using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model.AbstractClasses
{
    public abstract class Fallable : Drawable, IMovable
    {
        public bool IsDropping { get; set; } = false;

        public virtual void Move()
        {
            switch (Node.Bottom.Data)
            {
                case IExplodable e:
                    if (IsDropping)
                        e.Explode();
                    break;
                case null:
                    DrawableDown();
                    break;
                default:
                    IsDropping = false;
                    break;
            }
        }

        public override void Destroy()
        {
            base.Destroy();
            DisposeAction.Invoke(this);
        }

        public Action<IMovable> DisposeAction { get; set; }

        public void DrawableDown()
        {
            var newLocation = Node.Bottom;
            IsDropping = true;
            Node.Data = null;
            Node = newLocation;
            newLocation.Data = this;
        }
    }
}