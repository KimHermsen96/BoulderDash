using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Controller.Parser
{
    public class ParseLevel
    {
        private MainController mainController;

        private LinkedList linkedList;
        private LevelData levelData;
        private char[,] LevelArray;


        public ParseLevel(MainController mainController)
        {
            this.mainController = mainController;

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

        private IDrawable CreateObject(char drawable)
        {
            switch (drawable)
            {
                case 'R':
                    return Rockford = new Rockford();
                    break;
                case 'F':
                    return Firefly = new Firefly(); 
                default:
                    return null;
                    break;
            } 
        }

    }
}

