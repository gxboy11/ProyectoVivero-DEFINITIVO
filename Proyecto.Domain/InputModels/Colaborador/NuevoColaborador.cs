using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Colaborador
{
    public class NuevoColaborador
    {
        [Required]
        [StringLength(25, MinimumLength = 2)]
        [DisplayName("Nombre")]
        public string NombreColaborador { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Apellido")]
        public string ApellidoColaborador { get; set; }

        [Required]
        [StringLength(9)]
        [DisplayName("Cedula")]
        public string CedulaColaborador { get; set; }

        [Required]
        [DisplayName("Correo Electrónico")]
        public string CorreoElectronico { get; set; }

        [Required]
        [DisplayName("Numero Telefónico")]
        public string NumeroTelefono { get; set; }

        [Required]
        [DisplayName("Direccion")]
        public string DireccionColaborador { get; set; }

        [Required]
        [DisplayName("Direccion")]
        public float SalarioColaborador { get; set; }


    }
}
