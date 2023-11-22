using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Productos
{
    public class Producto
    {
        public Producto(int idProducto, string nombreProducto, string descripcionProducto, string idCategoria, string precioProducto, string imagenProducto)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            IdCategoria = idCategoria;
            PrecioProducto = precioProducto;
            ImagenProducto = imagenProducto;
        }

        public int IdProducto { get; private set; }

        public string NombreProducto { get; private set; }

        public string DescripcionProducto { get; private set; }

        public string IdCategoria { get; private set; }

        public string PrecioProducto { get; private set; }

        public string ImagenProducto { get; private set; }

      
        public bool HasChanged { get; private set; }


        public void Update(string nombreProducto, string descripcionProducto, string idCategoria, string precioProducto, string imagenProducto)
        {
            HasChanged =
                !nombreProducto.Equals(NombreProducto, StringComparison.OrdinalIgnoreCase) &&
                !descripcionProducto.Equals(DescripcionProducto, StringComparison.OrdinalIgnoreCase) &&
                !idCategoria.Equals(IdCategoria, StringComparison.OrdinalIgnoreCase) &&
                !precioProducto.Equals(PrecioProducto, StringComparison.OrdinalIgnoreCase) &&
                !imagenProducto.Equals(ImagenProducto, StringComparison.OrdinalIgnoreCase);

            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            IdCategoria = idCategoria;
            PrecioProducto = precioProducto;
            ImagenProducto = imagenProducto;
        }
    }
}
