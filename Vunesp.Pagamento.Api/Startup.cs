using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Vunesp.Pagamento.IoC;

namespace Vunesp.Pagamento.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
                     .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                     .AddJsonFormatters()
                     .ConfigureApiBehaviorOptions(options =>
                     {
                         options.SuppressConsumesConstraintForFormFileParameters = true;
                         options.SuppressInferBindingSourcesForParameters = true;
                         options.SuppressModelStateInvalidFilter = true;
                         options.SuppressMapClientErrors = true;
                     });

            services.AddMvc()
                     .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                     .ConfigureApiBehaviorOptions(options =>
                     {
                         options.SuppressConsumesConstraintForFormFileParameters = true;
                         options.SuppressInferBindingSourcesForParameters = true;
                         options.SuppressModelStateInvalidFilter = true;
                         options.SuppressMapClientErrors = true;
                     });

            services.AddMvcCore().AddApiExplorer();
            services.AddAutoMapper();


            // Adiciona o Swagger
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Info { Title = "Vunesp API Pagamento", Version = "v1" }));

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vunesp API Pagamento");
            }); 

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            RegisterInjectionPagamento.RegisterServices(services);
        }
    }
}
