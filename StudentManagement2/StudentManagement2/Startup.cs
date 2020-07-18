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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions();
                developerExceptionPageOptions.SourceCodeLineCount = 10;
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);

            }
            app.UseFileServer();
            app.Run(async (context) =>
            {
                throw new Exception("您的请求在管道中发生了一些错误，请检查");
                await context.Response.WriteAsync("Hello word");
            });

        }
    }
}
