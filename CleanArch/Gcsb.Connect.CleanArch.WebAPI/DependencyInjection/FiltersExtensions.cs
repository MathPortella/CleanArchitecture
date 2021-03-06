using Gcsb.Connect.CleanArch.WebAPI.Filters;
using Gcsb.Connect.Pkg.Startup.Webapi.Filters;
using Gcsb.Connect.Pkg.Startup.Webapi.Pipeline;

namespace Gcsb.Connect.CleanArch.WebAPI.DependencyInjection
{
    public static class FiltersExtensions
    {
        public static IServiceCollection AddCustomFilters(this IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(DomainExceptionFilter));
                options.Filters.Add(typeof(ValidateModelAttribute));
                options.Filters.Add(typeof(NotificationFilter));
                options.Conventions.Add(new NotFoundResultApiConvention());
                options.Conventions.Add(new ProblemDetailsResultApiConvention());
            });

            return services;
        }
    }
}
