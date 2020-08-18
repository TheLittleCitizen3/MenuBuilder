using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    abstract class BaseMenu<T> : IMenu<T>
    {
        public abstract Dictionary<T, ITakeAction<T>> ActionItems { get; set; }
        public abstract string ActionName { get; set; }

        public abstract int Action();

    }
}
