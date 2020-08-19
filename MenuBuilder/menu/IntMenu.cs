using MenuBuilder.menu.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.menu
{
    class IntMenu : BaseMenu<string>
    {
        public IntMenu(List<IInputvalidation> inputvalidations, Dictionary<string,ITakeAction<string>> ActionItems)
        {
            this.ActionItems = ActionItems;
            this.Validations = new List<IInputvalidation>() { new IntInputValidation() };
            this.Validations.AddRange(inputvalidations);
            ActionName = default;

        }
    }
}
