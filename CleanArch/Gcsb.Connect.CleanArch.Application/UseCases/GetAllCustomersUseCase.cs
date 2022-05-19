using Gcsb.Connect.CleanArch.Application.Interfaces;
using Gcsb.Connect.CleanArch.Application.Repositories;
using Gcsb.Connect.CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Application.UseCases
{
    public class GetAllCustomersUseCase : IGetAllCustomersUseCase
    {
        private readonly ICustomerRepository customerRepository;
        public GetAllCustomersUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute()
        {
            var customer = customerRepository.GetAllCustomers();
        }
    }
}
