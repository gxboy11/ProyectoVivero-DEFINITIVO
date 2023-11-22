using Proyecto.Domain.EntityModels.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts.Repositories
{
    public interface IProductoRepository : IRepository<Producto>
    {
    }
}
