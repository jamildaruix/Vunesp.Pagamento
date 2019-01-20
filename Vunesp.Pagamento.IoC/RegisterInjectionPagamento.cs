using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Vunesp.Pagamento.Application.AutoMapper;
using Vunesp.Pagamento.Application.Interfaces;
using Vunesp.Pagamento.Application.Services;
using Vunesp.Pagamento.Data.Context;
using Vunesp.Pagamento.Data.Repository;
using Vunesp.Pagamento.Domain.Interfaces;

namespace Vunesp.Pagamento.IoC
{
    public class RegisterInjectionPagamento
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Application
            //services.AddSingleton(Mapper.Configuration);
            //services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddSingleton(AutoMapperConfig.RegisterMappings());

            services.AddScoped<IPagamentoAppService, PagamentoAppService>();

            #endregion

            #region Infra - Data
            //Contexts
            services.AddScoped<ContextEF>();

            services.AddScoped<IPagamentoRepository, PagamentoCandidatoRepository>();
            #endregion            
        }
    }
}