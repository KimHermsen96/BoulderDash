using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;
using BoulderDash.Model.AbstractClasses;

namespace BoulderDash.Controller
{
    public class CharacterFactory
    {
        private readonly Game _game;
        private GameProgress gameProgress;
        private MainController mainController;
        public CharacterFactory(Game game, int level, MainController mainController)
        {
            this.mainController = mainController;
            this.gameProgress = new GameProgress();
            _game = game;
            
        }

        public Drawable CreateObject(char drawable)
        {
            switch (drawable)
            {
                case 'R':
                    return _game.Rockford = new Rockford(gameProgress);
                case 'F':
                    Firefly firefly = new Firefly();
                    _game.MovableObject.Add(firefly);
                    return firefly;
                case 'M':
                    Mud Mud = new Mud();
                    return Mud;
                case 'B':
                    Boulder Boulder = new Boulder();
                    _game.MovableObject.Add(Boulder);
                    return Boulder; 
                case 'D':
                    Diamond Diamond = new Diamond();
                    gameProgress.DiamondsNeeded++;
                    _game.MovableObject.Add(Diamond);
                    return Diamond;
                case 'W':
                    Wall Wall = new Wall();
                    return Wall;
                case 'S':
                    Steelwall SteelWall = new Steelwall();
                    return SteelWall;
                case 'T':
                    Tnt Tnt = new Tnt();
                    _game.MovableObject.Add(Tnt);
                    return Tnt;
                case 'H':
                    HardendMud HardendMud = new HardendMud();
                    _game.MovableObject.Add(HardendMud);
                    return HardendMud;
                case 'E':
                    Exit exit = new Exit(gameProgress, mainController);
                    return exit;
                default:
                    return null;
            }
        }

    }
}
