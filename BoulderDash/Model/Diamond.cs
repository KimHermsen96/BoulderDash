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
    public class Diamond : SlidingObject
    {
  
        public override string ToString()
        {
            return "D";
        }

        public override void Interact(Rockford character)
        {
            //de inhoud van de node waar nu diamond in staat wordt character. 
            Node.Data = character;
            //de data van node locatie van rockford wordt null 
            character.Node.Data = null;
            //de nieuwe node van rockford wordt de node waar diamond nu in staat. 
            character.Node = Node;
        }
    }
}
