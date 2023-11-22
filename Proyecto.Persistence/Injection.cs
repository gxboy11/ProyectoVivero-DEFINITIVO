using Proyecto.Application.Contracts.Contexts;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.EntityModels.Cliente;
using Proyecto.Persistence.Contexts;
using Proyecto.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proyecto.Domain.EntityModels.Colaboradores;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.EntityModels.Usuarios;

namespace Proyecto.Persistence
{
    public static class Injection
    {
        public static IServiceCollection AddPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<ApplicationDbContext>());

            services.AddRepository<Cliente, IClienteRepository, ClienteRepository>();
            services.AddRepository<Colaborador, IColaboradorRepository, ColaboradorRepository>();
            services.AddRepository<Producto, IProductoRepository, ProductoRepository>();
            services.AddRepository<Usuario, IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
