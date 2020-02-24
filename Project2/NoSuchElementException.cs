using System;

namespace Project2
{
    public class NoSuchElementException : Exception
    {
        public NoSuchElementException(string message)
            : base(message)
        {

        }
    }
}
