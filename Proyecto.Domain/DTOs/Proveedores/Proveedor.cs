using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Proveedores
{
    public class Proveedor
    {
        public Proveedor(int idProveedor, string nombreProveedor, string correoProveedor, string direccionProveedor)
        {
            IdProveedor = idProveedor;
            NombreProveedor = nombreProveedor;
            CorreoProveedor = correoProveedor;
            DireccionProveedor = direccionProveedor;

    }

        public int IdProveedor { get; private set; }

        public string NombreProveedor { get; private set; }

        public string CorreoProveedor { get; private set; }

        public string DireccionProveedor { get; private set; }


        public bool HasChanged { get; private set; }


        public void Update(string nombreProveedor, string correoProveedor, string direccionProveedor)
        {
            HasChanged =
                !nombreProveedor.Equals(NombreProveedor, StringComparison.OrdinalIgnoreCase) &&
                !correoProveedor.Equals(CorreoProveedor, StringComparison.OrdinalIgnoreCase) &&
                !direccionProveedor.Equals(DireccionProveedor, StringComparison.OrdinalIgnoreCase);

            NombreProveedor = nombreProveedor;
            CorreoProveedor = correoProveedor;
            DireccionProveedor = direccionProveedor;
        }
    }
}
