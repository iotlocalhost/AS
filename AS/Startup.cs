using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AS
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            //services.AddApplicationInsightsTelemetry(Configuration);
            services.AddApiVersioning();
            services.AddMvc();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            //app.UseApplicationInsightsRequestTelemetry();
            //app.UseApplicationInsightsExceptionTelemetry();

            //Add subscribe reprefix api service
            app.Map(ApiRoutes.Prefix, api =>
            {
                api.UseMvc(routes =>
                {
                    //Routing all api service
                    routes.MapWebApiRoute(string.Empty, ApiRoutes.Template);
                });
            });
        }

        sealed class ApiRoutes
        {
            public const string Prefix = "/api";
            public const string Template = "{controller}/{action}";
        }

        sealed class ApiServiceConfigOption
        {
            public string Option1 { get; set; }
            public int Option2 { get; set; }
        }
    }
}
