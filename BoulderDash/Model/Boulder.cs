using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BoulderDash.Controller;
using BoulderDash.Model.AbstractClasses;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Boulder : SlidingObject
    {

        public override string ToString()
        {
            return "B";
        }

        public override void Interact(Rockford character)
        {
            if (Node.Right == character.Node)
            {
                if (Node.Left.Data == null)
                {
                    Node.Left.Data = this;
                    Node.Data = character;
                    character.Node.Data = null;
                    character.Node = Node;
                    Node = this.Node.Left;
                }
            }
            else
            {
                if (Node.Right.Data == null)
                {
                    // de rechternode wordt boulder. 
                    Node.Right.Data = this;
                    //de inhoud van de node waar nu boulder in staat wordt character. 
                    Node.Data = character;
                    //de data van node locatie van rockford wordt null 
                    character.Node.Data = null;
                    //de huidige node van het character is deze node. 
                    character.Node = Node;
                    //de huidige node van dit characer is de rechternode. 
                    Node = this.Node.Right;
                    //de nieuwe node van rockford wordt de node waar boulder nu in staat. 
                }
            }
        }
    }
}
