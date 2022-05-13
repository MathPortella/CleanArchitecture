using AutoMapper;
using Gcsb.Connect.CleanArch.Domain.Entities;
using Gcsb.Connect.CleanArch.Infrastructure.Database.Entities;

namespace Gcsb.Connect.CleanArch.Infrastructure.Database.AutoMapperProfile
{
    public class InfraDomainProfile : Profile
    {
        public InfraDomainProfile()
        {
            CreateMap<Customer, CustomerInfra>().ReverseMap();
        }
    }
}