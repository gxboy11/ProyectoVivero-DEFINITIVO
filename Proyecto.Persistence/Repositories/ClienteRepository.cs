using Proyecto.Application.Diagnostics;
using Proyecto.Persistence.Contexts;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.EntityModels.Cliente;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext dbContext, IOptions<Guard> guard)
            : base(dbContext, guard)
        {
        }
    }
}
