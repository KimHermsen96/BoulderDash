using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public abstract class Drawable 
    {
        public Node Node { get; set; }


        public virtual void Destroy()
        {
            Node.Data = null;
        }

        //  public override abstract string ToString();
        //
        //        public abstract void PlayerInteract(Node newlocation);
        //        public abstract void BolderInteract();
        //        public abstract void RubbleInteract();
        //        public abstract void FireFlyInteract();
        //        public abstract void DiamondInteract();

        public virtual void Interact(Rockford character)
        {

        }
    }
}
