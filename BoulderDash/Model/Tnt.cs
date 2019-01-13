using BoulderDash.Model.AbstractClasses;
using BoulderDash.Model.Extensions;
using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model
{
    class Tnt : SlidingObject, IExplodable
    {
        private int counter = 0;
        private bool explode = false;
        public void Explode()
        {   
            this.ExplodeExt();
        }
        public override void Interact(Rockford character)
        {
            //de inhoud van de node waar nu mud in staat wordt character. 
            Node.Data = character;
            //de data van node locatie van rockford wordt null 
            character.Node.Data = null;
            //de nieuwe node van rockford wordt de node waar mud nu in staat. 
            character.Node = Node;
            //uit de lijst van movable objecten halen. 
            DisposeAction.Invoke(this);

        }
        public override void Move()
        {
            base.Move();
            if(this.IsDropping)
            {
                explode = true;
            }
            else if(!this.IsDropping && explode)
            {
                this.Explode();
            }
            counter++;
            if (counter >= 90) Explode();
        }

        public override string ToString()
        {
            return "T";
        }
    }
}