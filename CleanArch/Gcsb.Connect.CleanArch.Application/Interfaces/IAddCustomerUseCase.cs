using Gcsb.Connect.CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Application.Interfaces
{
    public interface IAddCustomerUseCase 
    {
        void Execute(Customer customer);
    }
}
