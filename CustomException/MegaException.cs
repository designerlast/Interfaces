using System;

namespace IntellVega.CBB.Interfaces.CustomException
{
    public class MegaException : Exception
    {
        public MegaException()
        {

        }
        public MegaException(string message) : base(message)
        {

        }

        public MegaException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
