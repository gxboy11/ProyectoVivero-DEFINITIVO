using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Producto
{
    public class NuevoProducto
    {
        [Required]
        [StringLength(25, MinimumLength = 2)]
        [DisplayName("Nombre Producto")]
        public string NombreProducto { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        [DisplayName("Descripcion Producto")]
        public string DescripcionProducto { get; set; }

        [Required]
        [DisplayName("Categoria")]
        public int? IdCategoria { get; set; }

        [Required]
        [DisplayName("Precio Producto")]
        public string PrecioProducto { get; set; }

        [Required]
        [DisplayName("Imagen Producto")]
        public IFormFile ImagenProducto { get; set; }
    }
}
