using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;
using BoulderDash.Model.StaticData;

namespace BoulderDash.Controller.Parser
{
    public class ParseLevel
    {
        private LevelData levelData;
        private char[,] LevelArray;
        public CharacterFactory CharacterFactory;
        public Game game;


        public ParseLevel()
        {
            levelData = new LevelData();
        }

        public Game ChooseLevel(int level)
        {
            var game = new Game();
            CharacterFactory = new CharacterFactory(game, level);

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
            
            game.LinkedList = CreateField();
            game.MovableObject.ForEach(x => x.DisposeAction = game.DisposeMovable);
            return game;

        }

        public LinkedList CreateField()
        { 
            var linkedlist = new LinkedList();
            for (int i = 0; i < LevelArray.GetLength(0); i++)
            {
                for (int j = 0; j < LevelArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        linkedlist.AppendRightAndBreak(true, CharacterFactory.CreateObject(LevelArray[i, j]));
                    }
                    else
                    {
                        linkedlist.AppendRightAndBreak(false, CharacterFactory.CreateObject(LevelArray[i, j]));
                    }
                }
            }

            return linkedlist;
        }
    }
}

