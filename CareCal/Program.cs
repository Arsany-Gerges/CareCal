using CareCal.Core.Models.Repository;
using CareCal.EF;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace CareCal.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<CareCalDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"),b => b.MigrationsAssembly(typeof(CareCalDbContext).Assembly.FullName));
            });

            builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy1", policy =>
                {
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            }
            );

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseStaticFiles();

            app.UseCors("MyPolicy1");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
