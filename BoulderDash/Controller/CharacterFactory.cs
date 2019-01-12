using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;

namespace BoulderDash.Controller
{
    public class CharacterFactory
    {
        private readonly Game _game;

        public CharacterFactory(Game game)
        {
            _game = game;
        }

        public Model.Drawable CreateObject(char drawable)
        {
            switch (drawable)
            {
                case 'R':
                    return _game.Rockford = new Rockford(); ;
                case 'F':
                    Firefly firefly = new Firefly();
                    _game.MovableObject.Add(firefly);
                    // mainController.mainModel.Fireflies.Add(firefly);
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
                    _game.MovableObject.Add(Diamond);
                    return Diamond;
                case 'W':
                    Wall Wall = new Wall();
                    return Wall = new Wall();
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
                    return HardendMud = new HardendMud();
                default:
                    return null;
            }
        }

    }
}
