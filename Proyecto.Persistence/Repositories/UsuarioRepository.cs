using Microsoft.Extensions.Options;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Application.Diagnostics;
using Proyecto.Domain.EntityModels.Usuarios;
using Proyecto.Persistence.Contexts;
using Proyecto.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Persistence.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext dbContext, IOptions<Guard> guard)
            : base(dbContext, guard)
        {
        }
    }
}
