using CrossCutting.ConfigureDependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApplication {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            ConfigureService.ConfigureDepedencieServices(services);
            ConfigureRespository.ConfigureDepedencieRepository(services);
            services.AddControllers(); //Essa linha acho que é padrão então não preciso recapitular ela
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Version="v1",
                    Title="API REGISTER STUDENTS",
                    Description="Contrução de Api com a arquitetura DDD",
                    TermsOfService= new Uri("https://github.com/Christian-M-Silva"),
                    Contact = new OpenApiContact { 
                        Name = "Christian",
                        Email = "tininjacms@gmail.com",
                        Url = new Uri("https://github.com/Christian-M-Silva")
                    },
                    License = new OpenApiLicense { 
                        Name= "Terms of License",
                        Url = new Uri("https://github.com/Christian-M-Silva")
                    }
                });
            }); // Adicionando o Swagger
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Student");
                c.RoutePrefix = string.Empty;
            }); //Configuração do swagger com o nome da Api e a rota dela

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
