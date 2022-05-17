using AutoMapper;
using Gcsb.Connect.CleanArch.Application.Repositories;
using Gcsb.Connect.CleanArch.Domain.Entities;
using Gcsb.Connect.CleanArch.Infrastructure.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Infrastructure.Database.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private Context context;
        private IMapper mapper;
        public CustomerRepository(Context context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var result = context.Customers.ToList();
            return mapper.Map<IEnumerable<Customer>>(result);
        }

        public Customer GetCustomerById(Guid Id)
        {
            var result = context.Customers.Find(Id);
            return mapper.Map<Customer>(result);
        }

        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(mapper.Map<CustomerInfra>(customer));
            context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(mapper.Map<CustomerInfra>(customer));
            context.SaveChanges();
        }

        public void RemoveCustomer(Guid Id)
        {
            var result = context.Customers.Find(Id);
            context.Customers.Remove(result);
            context.SaveChanges();
        }

    }
}
