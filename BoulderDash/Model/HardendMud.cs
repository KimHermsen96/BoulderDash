using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller;
using BoulderDash.Model.AbstractClasses;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class HardendMud : Fallable 
    {
        private int counter = 0;
        private bool rubble => counter >= 3;
        
        public override string ToString()
        {
            if (rubble) return "h";

            return "H"; 
        }

        public override void Move()
        {
            if (rubble)
            {
                base.Move();
            }
        }

        public override void Interact(Rockford character)
        {
            counter++;
        }
    }
}
