using Karamem0.Samples.Models.Builder;
using Karamem0.Samples.Models.Facades;
using Karamem0.Samples.Models.Repositories;
using Karamem0.Samples.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karamem0.Samples
{

    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<SampleDbContext>(options =>
                options.UseSqlServer(this.Configuration.GetConnectionString("SampleDbContext")));
            services.AddTransient<IExpenseService, ExpenseService>();
            services.AddTransient<IEmployeeFacade, ExpenseFacade>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Expense}/{action=Index}/{id?}");
            });
            app.UseAutoMapper();
            app.UseSeeded();
        }

    }

}
