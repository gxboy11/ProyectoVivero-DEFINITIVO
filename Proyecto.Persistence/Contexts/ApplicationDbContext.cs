using Proyecto.Application.Contracts.Contexts;
using Proyecto.Domain.EntityModels.Cliente;
using Proyecto.Domain.EntityModels.Colaboradores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.EntityModels.Usuarios;

namespace Proyecto.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
