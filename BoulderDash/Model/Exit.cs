using BoulderDash.Controller;
using BoulderDash.Controller.Parser;
using System;

namespace BoulderDash.Model
{
    class Exit : Drawable
    {
        private GameProgress gameProgress;
        private MainController mainController;

        public Exit(GameProgress gameProgress, MainController mainController)
        {
            this.mainController = mainController;
            this.gameProgress = gameProgress;
        }

        public override string ToString()
        {
            if (gameProgress.DiamondsNeeded == gameProgress.DiamondsGot)
            {
                return "E";
            }
            else
            {
                return "█";
            }
        }

        public override void Interact(Rockford character)
        {
            if(gameProgress.DiamondsNeeded == gameProgress.DiamondsGot)
            {
                try
                {
                    mainController.Parser = new ParseLevel();
                    mainController.game = mainController.Parser.ChooseLevel(2, mainController);
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Game over.");
                }
            }
        }
    }
}