using System;

namespace Gcsb.Connect.CleanArch.Application
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string businessMessage)
               : base(businessMessage)
        {
        }
    }
}
