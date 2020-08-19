using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.menu.Exceptions
{
    public class InavlidActionInputException : Exception
    {
        public InavlidActionInputException()
        {
        }
        public InavlidActionInputException(string messege) : base(messege)
        {
        }
    }
}
