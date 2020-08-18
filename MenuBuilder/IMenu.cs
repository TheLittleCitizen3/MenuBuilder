using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MenuBuilder
{
    interface IMenu<T> : ITakeAction<T>
    {
        Dictionary<T,ITakeAction<T>> ActionItems { get; set; }
    }
}
