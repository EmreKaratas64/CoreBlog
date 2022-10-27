using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog
{
    public class Startup
    {
        private IConfiguration _config { get; }

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequireUppercase = false;
                x.SignIn.RequireConfirmedEmail = true;
            }).AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();

            services.AddControllersWithViews();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            {
                x.LoginPath = "/WriterLogin/LoginWriter/";
            });


            services.ConfigureApplicationCookie(options =>
            {
                // cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.AccessDeniedPath = new PathString("/UserLogin/AccessDenied/");
                options.LoginPath = "/UserLogin/UserLogin/";
                options.SlidingExpiration = true;
            });

            var mailKitOptions = _config.GetSection("Email").Get<MailKitOptions>();
            services.AddMailKit(config=>config.UseMailKit(mailKitOptions));
            

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPages/ErrorPage404/", "?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=Bloglar}/{id?}");
            });


        }
    }
}
