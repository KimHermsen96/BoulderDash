using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Steelwall : Wall
    {
        
        public override string ToString()
        {
            return "█";
        }

        public override void Destroy()
        {
        }
    }
}
