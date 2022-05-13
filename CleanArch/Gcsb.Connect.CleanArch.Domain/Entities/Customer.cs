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
        public int Rg { get; private set; }
        public int Cpf { get; private set; }
        public string Address { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public bool ClientActive { get; private set; }

        public Customer(string name, string birthDate, int rg, int cpf, string address) //adicionar
        {
            Id = Guid.NewGuid();
            Name = name;
            BirthDate = birthDate;
            Rg = rg;
            Cpf = cpf;
            Address = address;
            RegistrationDate = DateTime.UtcNow;
            ClientActive = true;

            Validate(this, new CustomerValidator());
        }

        public Customer(Guid id, string name, string birthDate, int rg, int cpf, string address) //editar através do ID
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Rg = rg;
            Cpf = cpf;
            Address = address;
            RegistrationDate = DateTime.UtcNow;
            ClientActive = true;

            Validate(this, new CustomerValidator());
        }
    }
}