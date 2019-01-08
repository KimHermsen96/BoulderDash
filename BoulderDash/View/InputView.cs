using BoulderDash.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.View
{
    class InputView
    {
        private MainController mainController;
        public InputView(MainController mainController)
        {
            this.mainController = mainController;
        }

        public void Input()
        {
            bool x = true;
            while (x)
            {
                var ch = Console.ReadKey(false).Key;
                mainController.input.GameMove(ch);
                Console.Clear();

            }
            Console.ReadKey();
        }
    }
}
