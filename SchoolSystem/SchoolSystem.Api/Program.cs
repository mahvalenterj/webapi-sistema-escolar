using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.OpenApi.Models;
using System.Reflection;


namespace SchoolSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSwaggerGen(options =>
            {
                var openApiInfo = new OpenApiInfo();

                openApiInfo.Title = "Documenta��o de WebApi SchoolSystem";
                openApiInfo.Description = "A documenta��o relata os m�todos e utiliza��es desta API";
                openApiInfo.License = new OpenApiLicense
                {
                    Name = "MIT",
                    Url = new Uri(@"http://www.mit.com/license")
                };
                openApiInfo.Contact = new OpenApiContact()
                {
                    Name = "Marianna Correa",
                    Email = "mahvalenterj@gmail.com"
                };

                options.SwaggerDoc("v1", openApiInfo);

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var path = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(path, true);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}