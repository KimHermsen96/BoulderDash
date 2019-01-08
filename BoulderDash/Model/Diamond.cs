using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Diamond : Drawable
    {
        public override Node Node { get; set; }

        public override string ToString()
        {
            return "D";
        }

        public override void PlayerInteract()
        {
            throw new NotImplementedException();
        }

        public override void BolderInteract()
        {
            throw new NotImplementedException();
        }

        public override void RubbleInteract()
        {
            throw new NotImplementedException();
        }

        public override void FireFlyInteract()
        {
            throw new NotImplementedException();
        }

        public override void DiamondInteract()
        {
            throw new NotImplementedException();
        }
    }
}
