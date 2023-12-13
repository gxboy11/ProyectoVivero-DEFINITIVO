using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Proveedor
{
    public class ProveedorExistente
    {
        public int IdProveedor { get; set; }

        public string NombreProveedor { get; set; }

        public string CorreoProveedor { get; set; }

        public string DireccionProveedor { get; set; }
    }
}
