using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lesson2HandsOn
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.Run(async (context) =>
            {
                
                var cookie = context.Request.Cookies["MyCoolLittleCookie"];

                if (string.IsNullOrWhiteSpace(cookie))
                {
                    DateTime now = DateTime.Now;
                    DateTime expires = now + TimeSpan.FromSeconds(15);
                    context.Response.Cookies.Append
                    (
                        "MyCoolLittleCookie",
                        "Cookie created at: " + now.ToString("h:mm:ss tt"),
                        new CookieOptions
                        {
                            Path = "/",
                            HttpOnly = false,
                            Secure = false,
                            Expires = expires
                        }
                    );
                }

                string response =
                    "<h1>HTTP Cookies</h1>" +
                    $"<p>This is the cookie value received from browser: \"<strong>{cookie}</strong>\".</p>" +
                    "<p>Refresh page to see current cookie value...</p>" +
                    "<p>Cookie expires after 15 seconds.</p>";
                await context.Response.WriteAsync(response);
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
