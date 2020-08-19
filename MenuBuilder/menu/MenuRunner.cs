using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.menu
{
    class MenuRunner<T>
    {
        public BaseMenu<T> Menu { get; set; }

        public void Start()
        {
            Menu.PrintMenuOptions();
            Menu.ReadUserSelection();
            while (!Menu.ValidateUserInput())
            {
                Menu.ReadUserSelection();
            }
            Menu.Act();
        }

    }
}
