using Proyecto.Domain.EntityModels.Carritos;
using Proyecto.Domain.EntityModels.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Productos
{
    public class Producto : Entity
    {
        public Producto(string nombreProducto, string descripcionProducto, int? idCategoria, string precioProducto, string imagenProducto)
        {
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            IdCategoria = idCategoria;
            PrecioProducto = precioProducto;
            ImagenProducto = imagenProducto;

        }

        [Key]
        public int IdProducto { get; private set; }

        public string NombreProducto { get; private set; }

        public string DescripcionProducto { get; private set; }

        public int? IdCategoria { get; private set; }

        public string PrecioProducto { get; private set; }

        public string ImagenProducto { get; private set; }


        /// <summary>
        /// Llaves Foraneas
        /// </summary>
        [ForeignKey(nameof(IdCategoria))]
        public Categoria Categoria { get; set; }


        public void Update(string nombreProducto, string descripcionProducto, int? idCategoria, string precioProducto, string imagenProducto)
        {
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            IdCategoria = idCategoria;
            PrecioProducto = precioProducto;
            ImagenProducto = imagenProducto;
        }

    }
}
