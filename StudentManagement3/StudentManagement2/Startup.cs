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

        //������һ�����캯��(����ctor��Ȼ������tab��������һ�����캯��)
        public Startup(IConfiguration configuration)
        {
            //��Ҫ����һ������
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //��ӷ�����������������Ϣ
            //���ʹ��mvc
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            
            //ʹ��ConfigureServices����Ϣ
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            //else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment("UAT"))
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            app.UseStaticFiles();
      

            //����������development�������ɻ�����integration�������Ի���(testing)��QA��֤��ģ�⻷����staging��������������production��
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello WOrd");
            });

        }
    }
}
