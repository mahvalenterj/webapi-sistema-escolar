using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;

namespace SchoolSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                var openApiInfo = new OpenApiInfo
                {
                    Title = "Documentação de WebApi SchoolSystem",
                    Description = "A documentação relata os métodos e utilizações desta API",
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri(@"http://www.mit.com/license")
                    },
                    Contact = new OpenApiContact
                    {
                        Name = "Marianna Correa",
                        Email = "mahvalenterj@gmail.com"
                    }
                };

                options.SwaggerDoc("v1", openApiInfo);

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var path = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(path, true);
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "API SchoolSystem v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
