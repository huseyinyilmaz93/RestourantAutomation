using System;

namespace RA.Kernel.Exceptions
{
    public class ApiException : Exception
    {
        public readonly short StatusCode;
        public ApiException(string message, short statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
