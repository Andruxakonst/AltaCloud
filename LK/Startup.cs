using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using LK.Data;
using LK.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using LK.Areas.Identity.Pages;


namespace LK
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();                                                                                               //��������� Razor pages
            //services.AddIdentity<IdentityUser, IdentityRole>().AddErrorDescriber<RussianIdentityErrorDescriber>();      
            // ApplicationDbContext �������� �� �����! ������ ���!!! ���������� ��������������� ���������� � ������ �� ���� RussianIdentityErrorDescriber


            // �������� ������ ����������� �� ����� ������������
            string connectionDB = Configuration.GetConnectionString("DBConnection");                                                 //DefaultConnection ������� �� ����� appsettings.json
            // ��������� �������� MobileContext � �������� ������� � ����������
            services.AddDbContext<DBContext>(options =>
                options.UseMySql(connectionDB));                                                                                     //������ connection ������� �� ����� appsettings.json
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");                                                             //��������� �� ��������� ������ � ���������� home � ��� ����� index

                endpoints.MapControllerRoute(
                    name: "Data",
                    pattern: "{controller=Data}/{action=Data}");                                                                    //��������� �� ��������� ������ � ���������� data � ����� data
                endpoints.MapControllerRoute(
                    name: "Hello",
                    pattern: "{controller=Data}/{action=Hello}/{id?}");                                                                   //��������� �� ��������� ������ � ���������� Data � ����� Hello


                endpoints.MapRazorPages();

            });
        }
    }
}
