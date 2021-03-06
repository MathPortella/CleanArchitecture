using Autofac;
using Gcsb.Connect.CleanArch.Infrastructure.Modules;
using Xunit;
using Xunit.Abstractions;
using Xunit.Frameworks.Autofac;

[assembly: TestCollectionOrderer("Gcsb.Connect.CleanArch.Tests.TestCaseOrdering", "Gcsb.Connect.CleanArch.Tests")]
[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestFramework("Gcsb.Connect.CleanArch.Tests.ConfigureTestFramework", "Gcsb.Connect.CleanArch.Tests")]
namespace Gcsb.Connect.CleanArch.Tests
{
    public class ConfigureTestFramework : AutofacTestFramework
    {
        public ConfigureTestFramework(IMessageSink diagnosticMessageSink)
            : base(diagnosticMessageSink)
        {
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<ApplicationModule>();
            builder.RegisterModule<InfrastructureModule>();
            //builder.RegisterModule<WebAPIModule>();

            SetMockedDependencies(builder);
        }

        private static void SetMockedDependencies(ContainerBuilder builder)
        {
            //builder.RegisterInstance(new GetInvoicesMock().GetInvoices().Object).As<IGetInvoices>();
        }
    }
}