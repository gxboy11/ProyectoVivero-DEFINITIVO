using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Categorias
{
    public class Categoria
    {
        public Categoria(int idCategoria, string nombreCategoria, string descripcionCategoria)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            DescripcionCategoria = descripcionCategoria;

        }

        public int IdCategoria { get; private set; }

        public string NombreCategoria { get; private set; }

        public string DescripcionCategoria { get; private set; }

        public bool HasChanged { get; private set; }

        public void Update(string nombreCategoria, string descripcionCategoria)
        {
            HasChanged =
                !nombreCategoria.Equals(NombreCategoria, StringComparison.OrdinalIgnoreCase) &&
                !descripcionCategoria.Equals(DescripcionCategoria, StringComparison.OrdinalIgnoreCase);

            NombreCategoria = nombreCategoria;
            DescripcionCategoria = descripcionCategoria;
        }
    }
}
