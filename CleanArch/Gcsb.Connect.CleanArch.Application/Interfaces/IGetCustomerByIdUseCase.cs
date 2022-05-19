using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Application.Interfaces
{
    public interface IGetCustomerByIdUseCase
    {
        void Execute(Guid Id);
    }
}
