using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StudentManagement5.Moudles;

namespace StudentManagement5
{
    public class Startup
    {
 
        private readonly IConfiguration _configuration;

        //先声明一个构造函数(输入ctor，然后按两次tab键，声明一个构造函数)
        public Startup(IConfiguration configuration)
        {
            //需要声明一个内容
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("StudentDBConnection"))
                );
            
            //Mvc Core  只包含了核心的mvc功能
            //mvc   包含了依赖于mvc core 以及相关的第三方常用的服务和方法
            services.AddMvc();


            //services.AddSingleton<IStudentRepository, MockStudentRepository>();
            services.AddScoped<IStudentRepository, SQLStudentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseMvc();


            //使用传统路由模板

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=home}/{action=index}/{id?}");
            }); 
            // app.UseMvcWithDefaultRoute();
            /*
             传统路由
             */
            //app.UseMvc(routes =>
            //{
            //   routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //}

            // );
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});




        }


    }
}
