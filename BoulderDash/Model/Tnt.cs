using BoulderDash.Model.Extensions;
using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model
{
    class Tnt : SlidingObject, IExplodable
    {
        private int counter = 0; 

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
            counter++;
            if (counter >= 30) Explode();
        }

        public override string ToString()
        {
            return "T";
        }
    }
}