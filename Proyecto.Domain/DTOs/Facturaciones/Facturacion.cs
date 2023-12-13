using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Facturaciones
{
    public class Facturacion
    {
        public Facturacion(int idFacturacion, int idProducto, int idUsuario, float precioTotal)
        {
            IdFacturacion = idFacturacion;
            IdProducto = idProducto;
            IdUsuario = idUsuario;
            PrecioTotal = precioTotal;

        }

        public int IdFacturacion { get; private set; }

        public int IdProducto { get; private set; }

        public int IdUsuario { get; private set; }

        public float PrecioTotal { get; private set; }

        public void Update(int idProducto, int idUsuario, float precioTotal)
        {
            IdProducto = idProducto;
            IdUsuario = idUsuario;
            PrecioTotal = precioTotal;
        }
    }
}
