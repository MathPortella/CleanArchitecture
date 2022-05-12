using System.Security.Principal;

namespace Gcsb.Connect.CleanArch.WebAPI.Infrastructure.Services
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
