using System;

namespace Shapes
{
    public class InvalidSideExceptions : Exception
    {
        public InvalidSideExceptions(string message)
            : base(message)
        {
        }
    }
}
