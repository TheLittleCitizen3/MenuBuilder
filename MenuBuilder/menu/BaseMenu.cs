using MenuBuilder.menu;
using MenuBuilder.menu.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    abstract class BaseMenu<T> : IMenu<T>
    {
        public Dictionary<string, ITakeAction<T>> ActionItems { get; set; }
        public string ActionName { get; set; }
        public virtual List<IInputvalidation> Validations { get; set; }

        public virtual void Act()
        {
            ActionName = GetAction();
            if (ActionName == null)
            {
                throw new InavlidActionInputException("The Option Input is Invalid");
            }
            ActionItems[ActionName].Act();
        }

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

        private string GetAction()
        {
            
            foreach (var item in ActionItems.Keys)
            {
                if (ActionName == item)
                {
                    return ActionName;
                }
            }
            return null;
        }

    }
}
