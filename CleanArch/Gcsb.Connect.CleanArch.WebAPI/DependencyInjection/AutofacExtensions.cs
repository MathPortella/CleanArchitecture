using Autofac;
using Gcsb.Connect.CleanArch.Infrastructure.Modules;
using Gcsb.Connect.CleanArch.WebAPI.Module;

namespace Gcsb.Connect.CleanArch.WebAPI.DependencyInjection
{
    public static class AutofacExtensions
    {
        public static ContainerBuilder AddAutofacRegistration(this ContainerBuilder builder)
        {
            builder.RegisterModule<ApplicationModule>();
            builder.RegisterModule<InfrastructureModule>();
            builder.RegisterModule<WebAPIModule>();

            return builder;
        }
    }
}
