using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Facturaciones
{
    public class Facturacion : Entity
    {

        public Facturacion(int idProducto, int idUsuario)
        {
            IdProducto = idProducto;
            IdUsuario = idUsuario;

        }

        public void SetAdditionalInfo(float precioTotal)
        {
            PrecioTotal = precioTotal;
        }


        [Key]
        public int IdFacturacion { get; private set; }

        public int IdProducto { get; private set; }

        public int IdUsuario { get; private set; }

        public float PrecioTotal { get; private set; }


        public void Update(int idProducto, int idUsuario, float preciototal)
        {
            IdProducto = idProducto;
            IdUsuario = idUsuario;
            PrecioTotal = preciototal;
        }

    }
}
