using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Grants_data.Models;

namespace Grants_data
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string con = "Server=DESKTOP-DOQ4BTP\\SQLEXPRESS;Database=grant;Trusted_Connection=True;";
            // ������������� �������� ������
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(con));

            services.AddControllers(); // ���������� ����������� ��� �������������
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // ���������� ������������� �� �����������
            });
        }
    }
}
