﻿namespace Brasileirao.Api.Client.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message, params object[] args) 
            : base(message, args)
        {
        }
    }
}
