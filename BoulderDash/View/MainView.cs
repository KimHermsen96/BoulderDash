using BoulderDash.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.View
{
    class MainView
    {
        public Draw draw;
        private InputView inputView;
        private MainController mainController;

        public MainView(MainController mainController)
        {
            this.mainController = mainController;
            draw = new Draw(this.mainController);
        }
    }
}
