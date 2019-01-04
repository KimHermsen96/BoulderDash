using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash
{
    public class Game
    {
        LevelData leveldata = new LevelData();

        public void PrintLevel(int level)
        {
            var currentlevel = leveldata.getLevel1();
            int a = 0;
            int b = 40;

            switch (level)
            {
                case 1:
                    currentlevel = leveldata.getLevel1(); 
                    break;
                case 2:
                    currentlevel = leveldata.getLevel2();
                    break;
                case 3:
                    currentlevel = leveldata.getLevel3();
                    break;
                default:
                    break;
            }

            foreach (var l in currentlevel)
            {
                Console.Write(l);
                a++;
                if (a == b)
                {
                    Console.WriteLine();
                    b += 40; 
                }
            }

            Console.ReadKey();
        }
    }
}
