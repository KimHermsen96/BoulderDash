using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Wall : Drawable
    {
        public override Node Node { get; set; }

        public override string ToString()
        {
            return "W";
        }
    }
}
