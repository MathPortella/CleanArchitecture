using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string businessMessage)
           : base(businessMessage)
        {
        }
    }
}
