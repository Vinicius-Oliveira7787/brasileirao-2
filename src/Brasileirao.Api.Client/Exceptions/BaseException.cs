using System;
using System.Linq;

namespace Brasileirao.Api.Client.Exceptions
{
    public abstract class BaseException : Exception
    {
        protected BaseException(string message, params object[] args)
            : base(GetMessage(message, args))
        {
        }

        private static string GetMessage(string message, params object[] args)
        {
            if (string.IsNullOrWhiteSpace(message) || !(args?.Any() ?? false))
            {
                return message;
            }

            return string.Format(message, args);
        }
    }
}
