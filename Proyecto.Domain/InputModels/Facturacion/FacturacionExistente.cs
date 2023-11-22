using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Facturacion
{
    public class FacturacionExistente
    {
        public int IdFacturacion { get; set; }

        public int IdProducto { get; set; }

        public int IdUsuario { get; set; }

        public float PrecioTotal { get; set; }
    }
}
