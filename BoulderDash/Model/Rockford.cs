using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Rockford : Character,  IExplodable
    {
        public override string ToString()
        {
            return "R";
        }

        public void Explode()
        {
            throw new NotImplementedException();
        }


        public override void MoveTo(Node newLocation)
        {
            if (newLocation.Data != null)
            {
                newLocation.Data.Interact(this);
            }
            else
            {
                base.MoveTo(newLocation);
            }
        }
    }
}