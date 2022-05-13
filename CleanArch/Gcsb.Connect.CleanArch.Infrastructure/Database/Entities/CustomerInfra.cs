using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Infrastructure.Database.Entities
{
    public class CustomerInfra
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
