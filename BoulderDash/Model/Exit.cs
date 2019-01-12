using BoulderDash.Controller;
using BoulderDash.Controller.Parser;
using System;

namespace BoulderDash.Model
{
    class Exit : Drawable
    {
        private GameProgress gameProgress;
        private Game game;

        public Exit(GameProgress gameProgress, Game game)
        {
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
                    ParseLevel parser = new ParseLevel();
                    game = parser.ChooseLevel(gameProgress.level++);
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