using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Producto
{
    public class ProductoExistente
    {
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public string IdCategoria { get; set; }

        public string PrecioProducto { get; set; }

        public string ImagenProducto { get; set; }
    }
}
