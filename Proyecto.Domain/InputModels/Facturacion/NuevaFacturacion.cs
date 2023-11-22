using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Facturacion
{
    public class NuevaFacturacion
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Id de Producto")]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Id de Usuario")]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Precio Total")]
        public float PrecioTotal { get; set; }
    }
}
