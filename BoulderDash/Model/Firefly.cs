using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Model
{
    public class Firefly : ICharacter, IDrawable
    {
        public Node Node { get; set; }

        public override string ToString()
        {
            return "F";
        }
    }
}
