using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.LinkedList;

namespace BoulderDash.Controller.Parser
{
    class ParseLevel
    {
        private LinkedList linkedList;
        private LevelData levelData;
        private char[,] LevelArray;

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
                        linkedList.AppendRightAndBreak(true, LevelArray[i, j]);
                        
                    }
                    else
                    {
                        linkedList.AppendRightAndBreak(false, LevelArray[i, j]);
                    }
                    
                }
            }
        }

        public void readParse()
        {
            Node x = linkedList.Head;
            Node y = linkedList.Head;

            while (true)
            {
                Console.Write(y.Data);
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

