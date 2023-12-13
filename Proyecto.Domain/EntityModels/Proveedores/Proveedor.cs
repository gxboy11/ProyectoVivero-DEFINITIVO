using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Proveedores
{
    public class Proveedor : Entity
    {

        public Proveedor(string nombreProveedor, string correoProveedor, string direccionProveedor)
        {
            NombreProveedor = nombreProveedor;
            CorreoProveedor = correoProveedor;
            DireccionProveedor = direccionProveedor;

        }

        [Key]
        public int IdProveedor { get; private set; }

        public string CorreoProveedor { get; private set; }

        public string NombreProveedor { get; private set; }

        public string DireccionProveedor { get; private set; }


        public void Update(string nombreProveedor, string correoProveedor, string direccionProveedor)
        {
            NombreProveedor = nombreProveedor;
            CorreoProveedor = correoProveedor;
            DireccionProveedor = direccionProveedor;
        }

    }
}
