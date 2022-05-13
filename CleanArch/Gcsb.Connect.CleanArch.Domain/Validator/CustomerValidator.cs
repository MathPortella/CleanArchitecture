using FluentValidation;
using Gcsb.Connect.CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Domain.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(r => r.Id).NotEmpty().NotEqual(new Guid());
            RuleFor(r => r.Name).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(r => r.BirthDate).NotEmpty().NotNull().MaximumLength(10);
            RuleFor(r => r.Rg).NotEmpty().NotNull().MaximumLength(12);
            RuleFor(r => r.Cpf).NotEmpty().NotNull().MaximumLength(11);
            RuleFor(r => r.Address).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(r => r.PostalCode).NotEmpty().NotNull();
        }
    }
}
