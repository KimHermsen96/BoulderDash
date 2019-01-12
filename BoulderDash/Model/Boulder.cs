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
    public class Boulder : SlidingObject
    {

        public override string ToString()
        {
            return "B";
        }

        public override void Interact(Rockford character)
        {

            // een bolder kan enkel naar links of naar rechts verplaatsen. 
            // de ruimte achter een bolder moet null zijn. 


            if (Node.Right == character.Node)
            {
                // als rechts van je rockford staat
                // dan moet je checken of links van je een plek vrij is (null)
                // zo ja dan kun je naar links verschuiven
                // en rockford ofcourse ook

                if (Node.Left.Data == null)
                {
                    //Het huidige ding war de bolder nu in staat word rockford. 
                    Node.Data = character;

                    //de node wordt de nieuwe node. 
                    Node = Node.Left;
                    // in het node op de nieuew plek wordt het huidige object opgeslagen. 
                    Node.Left.Data = this;
                }
            }
            else
            {
                if (Node.Right.Data == null)
                {

                }
            }
        }
    }

}
