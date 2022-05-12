using System;

namespace Gcsb.Connect.CleanArch.Application
{
    public class ApplicationException : Exception
    {
        internal ApplicationException(string businessMessage)
               : base(businessMessage)
        {
        }
    }
}
