using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MenuBuilder
{
    interface IMenu<T> : ITakeAction<T>
    {
        Dictionary<string,ITakeAction<T>> ActionItems { get; set; }
        List<IInputvalidation> Validations { get; set; }
    }
}
