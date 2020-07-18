using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace StudentManagement2
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
            //添加方法和依赖和配置信息
            //添加使用mvc
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            
            //使用ConfigureServices的信息
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            //else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment("UAT"))
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            app.UseStaticFiles();
      

            //开发环境（development）、集成环境（integration）、测试环境(testing)、QA验证、模拟环境（staging）、生产环境（production）
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello WOrd");
            });

        }
    }
}
