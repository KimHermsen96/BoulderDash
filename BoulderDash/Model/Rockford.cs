using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller;
using BoulderDash.Model.Extensions;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Rockford : Character,  IExplodable
    {
        public readonly GameProgress GameProgress;

        public Rockford(GameProgress gameProgress)
        {
            GameProgress = gameProgress;
        }

        public override string ToString()
        {
            return "R";
        }

        public override void Destroy()
        {

            throw new GameOverException();
        }

        public void Interact(Drawable obj)
        {

        }

        public override void MoveTo(Node newLocation)
        {

            //als er een object in zit kijk dan hoe rockford moet interacteren met dit obj. 
            if (newLocation.Data != null)
            {
                newLocation.Data.Interact(this);
            }
            else
            {      //ruimte is leeg rockford kan gwn bewegen. 
                base.MoveTo(newLocation);
            }
        }

        public void Explode()
        {
            this.ExplodeExt();
        }
    }
}