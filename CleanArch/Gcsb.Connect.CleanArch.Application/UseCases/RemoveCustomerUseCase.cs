using Gcsb.Connect.CleanArch.Application.Interfaces;
using Gcsb.Connect.CleanArch.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Application.UseCases
{
    public class RemoveCustomerUseCase : IRemoveCustomerUseCase
    {
        private readonly ICustomerRepository customerRepository;
        public RemoveCustomerUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(Guid Id)
        {
            customerRepository.RemoveCustomer(Id);
        }
    }
}
