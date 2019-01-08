using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Model
{
    public class Steelwall : Drawable
    {
        public override Node Node { get; set; }

        public override string ToString()
        {
            return "S";
        }
    }
}
