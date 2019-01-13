using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller;
using BoulderDash.Model.AbstractClasses;
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
            this.ChangeGameProgress(character);
            //de inhoud van de node waar nu diamond in staat wordt character. 
            Node.Data = character;
            DisposeAction.Invoke(this);
            //de data van node locatie van rockford wordt null 
            character.Node.Data = null;
            //de nieuwe node van rockford wordt de node waar diamond nu in staat. 
            character.Node = Node;
            //de node van diamond wordt de node waar eerst character in staat met data null. 
            Node = character.Node;
        }


        private void ChangeGameProgress(Rockford character)
        {
            character.GameProgress.DiamondsGot++;
        }
    }
}
