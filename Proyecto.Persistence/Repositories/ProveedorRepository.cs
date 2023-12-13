using Microsoft.Extensions.Options;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Application.Diagnostics;
using Proyecto.Domain.EntityModels.Proveedores;
using Proyecto.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Persistence.Repositories
{
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
        public ProveedorRepository(ApplicationDbContext dbContext, IOptions<Guard> guard)
            : base(dbContext, guard)
        {
        }
    }
}
