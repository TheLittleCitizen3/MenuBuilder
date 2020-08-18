using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    abstract class BaseMenu<T> : IMenu<T>
    {
        public abstract Dictionary<string, ITakeAction<T>> ActionItems { get; set; }
        public abstract string ActionName { get; set; }
        public abstract List<IInputvalidation> Validations { get; set; }

        public abstract void Action();

        public void PrintMenuOptions()
        {
            foreach (var item in ActionItems.Values)
            {
                Console.WriteLine(item.ActionName);
            }
        }

        public virtual void ReadUserSelection()
        {
            Console.WriteLine(">");
            string userInput = Console.ReadLine();
            ActionName = userInput;
        }

        public bool ValidateUserInput()
        {
            foreach (var validation in Validations)
            {
                if (!validation.Validate(ActionName))
                {
                    return false;
                }
            }
            return true;
        }



    }
}
