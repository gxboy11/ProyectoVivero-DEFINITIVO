using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Categoria
{
    public class NuevaCategoria
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Nombre")]
        public string NombreCategoria { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Descripcion de la Categoria")]
        public string DescripcionCategoria { get; set; }
    }
}
