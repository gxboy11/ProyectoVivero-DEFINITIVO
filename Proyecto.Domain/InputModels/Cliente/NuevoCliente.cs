using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Cliente
{
    public class NuevoCliente
    {
        [Required]
        [StringLength(25, MinimumLength = 2)]
        [DisplayName("Nombre")]
        public string NombreCliente { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Apellido")]
        public string ApellidoCliente { get; set; }

        [Required]
        [StringLength(9)]
        [DisplayName("Cedula")]
        public string CedulaCliente { get; set; }

        [Required]
        [DisplayName("Correo Electrónico")]
        public string CorreoElectronico { get; set; }

        [Required]
        [DisplayName("Numero Telefónico")]
        public string NumeroTelefono { get; set; }

        [Required]
        [DisplayName("Direccion")]
        public string DireccionCliente { get; set; }
    }
}
