using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MenuBuilder
{
    interface ITakeAction<T>
    {
        string ActionName { get; set; }
        public void Act();

    }
}
