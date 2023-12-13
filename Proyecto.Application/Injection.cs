using FluentValidation;
using Proyecto.Application.Contracts;
using Proyecto.Application.Diagnostics;
using Proyecto.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Proyecto.Application
{
    public static class Injection
    {
        public static IServiceCollection AddAplication
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Guard>(options => { });

            var assembly = typeof(Injection).Assembly;

            services.AddMediatR(options => options.RegisterServicesFromAssemblies(assembly));
            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IColaboradorService, ColaboradorService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IFacturacionService, FacturacionService>();
            services.AddScoped<IProveedorService, ProveedorService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
