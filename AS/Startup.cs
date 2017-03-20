using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Routing;
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

            if (env.IsDevelopment())
                builder.AddApplicationInsightsSettings(developerMode: true);

            else if (env.IsStaging())
                builder.AddApplicationInsightsSettings(developerMode: true);

            else if (env.IsProduction())
                builder.AddApplicationInsightsSettings(developerMode: true);

            else
                builder.AddApplicationInsightsSettings(developerMode: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework service
            services.AddRouting();
            services.AddMvc();

            // Add application service
            services.AddApiVersioning(o => o.ApiVersionReader = new HeaderApiVersionReader("api-version"));

            // Add Application Insights data collection services to the services container.
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            // Use framework service
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc(routes =>
            {
                routes.MapWebApiRoute(env.EnvironmentName, "{controller}/{action}");
            });

            // Use application service
        }

        sealed class ApiServiceConfigOption
        {
            public string Option1 { get; set; }
            public int Option2 { get; set; }
        }
    }
}
