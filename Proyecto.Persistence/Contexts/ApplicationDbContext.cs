using Proyecto.Application.Contracts.Contexts;
using Proyecto.Domain.EntityModels.Cliente;
using Proyecto.Domain.EntityModels.Colaboradores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.EntityModels.Categorias;
using Proyecto.Domain.EntityModels.Proveedores;
using Proyecto.Domain.EntityModels.Facturaciones;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.EntityModels.Usuarios;
using Proyecto.Domain.EntityModels.Carritos;

namespace Proyecto.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrito>()
                     .HasOne(c => c.Usuario)
                     .WithMany(u => u.Carrito)
    .HasForeignKey(c => c.UsuarioId)
    .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Facturacion> Facturaciones { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carrito> Carrito { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
