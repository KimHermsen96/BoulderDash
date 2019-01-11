using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class HardendMud : Mud , IMovable
    {

        public override string ToString()
        {
            return "H"; 
        }

        public void Move()
        {
            
        }
    }
}
