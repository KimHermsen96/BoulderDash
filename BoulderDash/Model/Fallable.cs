using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model
{
    public class Fallable : Drawable
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
            }
        }

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