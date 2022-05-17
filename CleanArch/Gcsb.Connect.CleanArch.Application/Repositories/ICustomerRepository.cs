using Gcsb.Connect.CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Application.Repositories
{
   public interface ICustomerRepository

    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(Guid Id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void RemoveCustomer(Guid Id); 
    }
}
