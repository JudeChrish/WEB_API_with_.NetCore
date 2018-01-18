using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ToDoApi.Abstract;
using ToDoApi.Concreet;
using Microsoft.EntityFrameworkCore;

namespace ToDoApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment Env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Env.EnvironmentName}.Jason", optional: true)
            .AddEnvironmentVariables();

            if(Env.IsDevelopment())
            {
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IToDoRepository, ToDoRepository>();
            services.AddDbContext<MvcWebApiContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:Default_Connection"]));

            services.AddScoped<IToDoRepository, ToDoRepository2>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
