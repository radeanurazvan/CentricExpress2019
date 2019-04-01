using System;

namespace CentricExpress.Business
{
    public class BusinessException : Exception
    {
        public string Error { get; }

        public BusinessException(string error)
        {
            Error = error;
        }
    }
}