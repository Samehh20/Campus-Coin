using CampusCoin.Common.Options;
using CampusCoin.Models;
using CampusCoin.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin
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
            
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.Configure<MIUOptions>(this.Configuration.GetSection(MIUOptions.MIU));
            services.AddScoped<ICampusCoinRepository<DepositTransaction>, DepositTransactionsDbRepository>();
            services.AddScoped<IUserDbRepository, UserDbRepository>();
            services.AddScoped<IWalletDbRepository, WalletDbRepository>();
           
            services.AddInfrastructure(this.Configuration);
            
           //services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      //  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseRouting();

           // app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});

            app.UseMvc(route => {
                route.MapRoute("default", "{controller=DepositTransaction}/{action=Index}/{id?}");
            });
        }
    }
}
