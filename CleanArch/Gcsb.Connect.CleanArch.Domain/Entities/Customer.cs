using Gcsb.Connect.CleanArch.Domain.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public string BirthDate { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }
        public string Address { get; private set; }
        public int PostalCode { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public bool IsActive { get; private set; }

        public Customer(string name, string birthDate, string rg, string cpf, string address, int postalCode)
        {
            Id = Guid.NewGuid();
            Name = name;
            BirthDate = birthDate;
            Rg = rg;
            Cpf = cpf;
            Address = address;
            PostalCode = postalCode;
            RegistrationDate = DateTime.UtcNow;
            IsActive = true;

            Validate(this, new CustomerValidator());
        }
    }
}