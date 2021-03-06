using Autofac;
using Autofac.Configuration;
using Autofac.Extensions.DependencyInjection;
using Gcsb.Connect.CleanArch.WebAPI.DependencyInjection;
using Gcsb.Connect.CleanArch.WebAPI.Pipeline;
using Gcsb.Connect.CleanArch.WebAPI.DependencyInjection;
using Gcsb.Connect.CleanArch.WebAPI.Pipeline;
using Gcsb.Connect.Pkg.Serilog.Implementation;
using Gcsb.Connect.Pkg.Startup.Webapi.DependencyInjection;
using Gcsb.Connect.Pkg.Startup.Webapi.Resources;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json.Converters;

namespace Gcsb.Connect.CleanArch.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ILifetimeScope AutofacContainer { get; private set; }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ConfigurationModule(Configuration));
            builder.AddAutofacRegistration();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddJwtToken();
            services.AddLocalization();
            services.AddVersioning();
            services.AddProblemDetails();
            services.AddCustomFilters();
            services.AddSwagger();
            services.Cors();
            services.AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });
            services.AddSwaggerGenNewtonsoftSupport();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            var serviceProvider = app.ApplicationServices;
            var resouces = serviceProvider.GetService<IStringLocalizer<ReturnMessages>>();

            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();

            app.UseExceptionHandler(new ExceptionHandlerOptions
            {
                ExceptionHandler = new ErrorHandlerMiddleware(env, resouces).Invoke
            });

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseMiddleware<LogRequestMiddleware>();
            app.AddLocalization();
            app.UseCors();
            app.UseProblemDetails();
            app.UseVersionedSwagger(provider);
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(e => e.MapControllers());
            app.AddOptions();
        }
    }
}
