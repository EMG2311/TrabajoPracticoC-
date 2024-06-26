using Application.Repositories;
using Infraestructure.Repositories.Sql;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using MyProyecto.CMD;
using System.Configuration;

namespace Web.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            // Configura el DbContext para usar MySQL
            services.AddDbContext<MyDbContext>(options =>
                options.UseMySQL("Server=localhost;port=3306;Database=productos;User=root;Password=root;"));

            services.AddScoped<ICustomerRepository, CustomerRespotirory>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment webHostEnvironment1)
        {
            if (webHostEnvironment1.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(Options => Options.MapControllers());

        }


    }
}
