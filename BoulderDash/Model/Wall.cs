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
        
        private int counter = 0;
        public override string ToString()
        {
            return "▓";
        }

    }
}
