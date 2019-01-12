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

        public virtual void Interact(Rockford character)
        {

        }
    }
}
