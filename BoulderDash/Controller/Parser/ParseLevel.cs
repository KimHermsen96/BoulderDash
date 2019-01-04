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
            Node accessor = null;
            Node accessorRow = linkedList.Head;

            for (int i = 0; i < LevelArray.GetLength(0); i++)
            {
                for (int j = 0; j < LevelArray.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        linkedList.AddFirst(LevelArray[i, j], null, null, null, null);
                        accessor = linkedList.Head;
                        continue;
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (i > 0)
                            {
                                linkedList.AddBottom(LevelArray[i, j], null, null, null, null, accessor);
                                accessor = accessor.Bottom;
                                accessorRow = accessor;
                                continue;
                            }
                            accessorRow = accessor;
                        }
                    }
                    linkedList.AddRight(LevelArray[i, j], null, null, null, null, accessor);
                    accessor = accessor.Right;
                }
            }
            accessor = accessorRow;
        }
    }
}

