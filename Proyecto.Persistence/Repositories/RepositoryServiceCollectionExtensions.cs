using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.EntityModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Persistence.Repositories
{
    public static class RepositoryServiceCollectionExtensions
    {
        public static IServiceCollection AddRepository<TEntity, TContact, TRepository>
            (this IServiceCollection services)
            where TEntity : Entity
            where TContact : class, IRepository<TEntity>
            where TRepository : class, TContact
        {
            services.AddScoped<TContact, TRepository>();
            return services;
        }
    }
}
