using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Mud : Drawable
    {
        
        public override string ToString()
        {
            return "░";
        }

        public override void Interact(Rockford character)
        {
            //de inhoud van de node waar nu mud in staat wordt character. 
            Node.Data = character;
            //de data van node locatie van rockford wordt null 
            character.Node.Data = null;
            //de nieuwe node van rockford wordt de node waar mud nu in staat. 
            character.Node = Node;
        }

    }
}
