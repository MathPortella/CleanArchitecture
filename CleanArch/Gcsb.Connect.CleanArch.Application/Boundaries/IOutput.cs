using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Application.Boundaries
{
    public interface IOutput<R>
    {
        void Standard(R result);
        void Error(string message);
        void NotFound(string message);
    }
}
