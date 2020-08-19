using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MenuBuilder.menu
{
    class StringMenu : BaseMenu<string>
    {
        public StringMenu(Dictionary<string, ITakeAction<string>> ActionItems, List<IInputvalidation> Validations)
        {
            this.ActionItems = ActionItems;
            this.Validations = Validations;
            ActionName = "";
        }
    }
}
