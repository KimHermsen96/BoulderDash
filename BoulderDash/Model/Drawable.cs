using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Model
{
    public abstract class Drawable
    {
        public abstract Node Node { get; set; }
        public override abstract string ToString();
    }
}
