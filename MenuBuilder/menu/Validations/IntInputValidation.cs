using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.menu.Validations
{
    class IntInputValidation : IInputvalidation
    {
        public bool Validate(string userInput)
        {
            int parsedInt;
            return int.TryParse(userInput, out parsedInt);
        }
    }
}
