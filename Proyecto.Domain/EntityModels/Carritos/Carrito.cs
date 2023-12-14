using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.EntityModels.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Carritos
{
    /// <summary>
    /// ESTA ENTIDAD SIRVE PARA ARREGLAR LA RELACION MUCHOS A MUCHOS ENTRE USUARIOS Y PRODUCTOS
    /// </summary>
    public class Carrito : Entity
    {
        public Carrito(int? usuarioId, int productoId)
        {
            this.UsuarioId = usuarioId;
            this.ProductoId = productoId;
        }

        [Key]
        public int Id { get; set; }

        public int? UsuarioId { get; set; }

        public int ProductoId { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuario Usuario { get; set; }

        [ForeignKey(nameof(ProductoId))]
        public Producto Producto { get; set; }

    }
}
