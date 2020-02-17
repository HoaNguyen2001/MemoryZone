using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using X.PagedList;
using project_banhang.Middlewares;
//using X.PagedList;

namespace project_banhang
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //cái này để sử dụng session
            services.AddSession();
            //cái này để sử dụng mvc
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //sử dụng sesssion,là biến dùng trên nhiều trang,
            app.UseSession();
            //sử dụng middlewares CheckLoginMiddleware.cs
            _ = app.UseMiddleware<CheckLoginMiddleware>();
            //sử dụng thư mục wwwroot
            app.UseStaticFiles();
            // sử dụng mô hình mvc


            app.UseMvc(route => {

                route.MapRoute(
                    name: "Default", template: "{Controller=Home}/{Action=Index}/{id?}"); 
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
