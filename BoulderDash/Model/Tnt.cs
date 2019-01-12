using BoulderDash.Model.Extensions;
using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model
{
    class Tnt : SlidingObject, IExplodable, IMovable
    {
        private int counter = 0; 

        public void Explode()
        {   
            this.ExplodeExt();
        }

        public override void Move()
        {
            base.Move();
            counter++;
            if (counter >= 30) Explode();
        }

        public override string ToString()
        {
            return "T";
        }
    }
}