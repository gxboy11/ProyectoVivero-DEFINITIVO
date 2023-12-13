using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Proveedor
{
    public class NuevoProveedor
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Nombre")]
        public string NombreProveedor { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Correo")]
        public string CorreoProveedor { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Direccion")]
        public string DireccionProveedor { get; set; }
    }
}
