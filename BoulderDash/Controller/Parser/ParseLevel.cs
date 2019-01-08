using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Controller.Parser
{
    public class ParseLevel
    {
        public LinkedList linkedList { get; set; }
        private LevelData levelData;
        private char[,] LevelArray;

        public Rockford Rockford { get; set; }
        public Firefly Firefly { get; set; }
        public ParseLevel()
        {
            levelData = new LevelData();
            linkedList = new LinkedList();
        }

        public void ChooseLevel(int level)
        {
            switch (level)
            {
                case 1:
                    LevelArray = levelData.getLevel1();
                    break;
                case 2:
                    LevelArray = levelData.getLevel2();
                    break;
                case 3:
                    LevelArray = levelData.getLevel3();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void Parse()
        { 
            for (int i = 0; i < LevelArray.GetLength(0); i++)
            {
                for (int j = 0; j < LevelArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        linkedList.AppendRightAndBreak(true, CreateObject(LevelArray[i, j]));
                    }
                    else
                    {
                        linkedList.AppendRightAndBreak(false, CreateObject(LevelArray[i, j]));
                    }
                    
                }
            }
        }

        private Drawable CreateObject(char drawable)
        {
            switch (drawable)
            {
                case 'R':
                    return Rockford = new Rockford();
                    break;
                case 'F':
                    return Firefly = new Firefly(); ;
                    break;
                case 'M':
                    Mud mud = new Mud();
                    return mud;
                case 'B':
                    Boulder boulder = new Boulder();
                    return boulder;
                case 'D':
                    Diamond diamond = new Diamond();
                    return diamond;
                case 'W':
                    Wall wall= new Wall();
                    return wall;
                case 'S':
                    Steelwall steelWall = new Steelwall();
                    return steelWall;
                case 'H':
                     HardendMud hardendMud = new HardendMud();
                    return hardendMud;
                default:
                    return null;
                    break;
            }
        }


        public void Print()
        {
            Node x = linkedList.Head;
            Node y = linkedList.Head;

            while (true)
            {
                if(y.Data == null) Console.Write("*");
                else
                {
                    Console.Write(y.Data);
                }

                if (y.Right != null)
                {
                    y = y.Right;
                }
                else if (x.Bottom != null)
                {
                    Console.WriteLine();
                    y = x.Bottom;
                    x = y;
                }
                else
                {
                    break;
                }
            }
        }
    }
}

