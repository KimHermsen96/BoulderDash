using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model.AbstractClasses
{
    public abstract class Drawable 
    {
        public Node Node { get; set; }

        public virtual void Destroy()
        {
            Node.Data = null;
            Node = null;
        }

        public virtual void Interact(Rockford character)
        {
        }
    }
}
