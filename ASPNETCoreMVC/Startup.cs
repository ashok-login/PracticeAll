using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.BLL;
using ASPNETCoreMVC.BLL.Contracts;
using ASPNETCoreMVC.BLL.Northwind.Contracts;
using ASPNETCoreMVC.BLL.Northwind.Implementations;
using ASPNETCoreMVC.DAL;
using ASPNETCoreMVC.DAL.Contracts;
using ASPNETCoreMVC.DAL.Northwind.Contracts;
using ASPNETCoreMVC.DAL.Northwind.Implementations;
using ASPNETCoreMVC.Models.Northwind;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPNETCoreMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<CompanyContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IDepartmentDAL, DepartmentDAL>();
            services.AddTransient<IDepartmentBLL, DepartmentBLL>();
            services.AddTransient<IEmployeeDAL, EmployeeDAL>();
            services.AddTransient<IEmployeeBLL, EmployeeBLL>();

            services.AddDbContext<NorthwindContext>(x => x.UseSqlServer(Configuration.GetConnectionString("NorthwindConnection")));
            services.AddTransient<IProductsDAL, ProductsDAL>();
            services.AddTransient<IProductsBLL, ProductsBLL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=TableSorter}/{action=Index}/{id?}");
            });
        }
    }
}
