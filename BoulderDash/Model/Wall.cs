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
            return "W";
        }

//        public override void PlayerInteract(Node newLocation)
//        {
//
//            if (counter == 3)
//            {
//                //Het huidige ding wordt leeg gemaakt. 
//                Node.Data = null;
//                //de node wordt de nieuwe node. 
//                Node = newLocation;
//                // in het node op de nieuew plek wordt het huidige object opgeslagen. 
//                newLocation.Data = this;
//            }
//            counter++;
//        }


    }
}
