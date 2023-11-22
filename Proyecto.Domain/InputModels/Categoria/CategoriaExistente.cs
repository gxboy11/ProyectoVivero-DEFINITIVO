using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Categoria
{
    public class CategoriaExistente
    {
        public int IdCategoria { get; set; }

        public string NombreCategoria { get; set; }

        public string DescripcionCategoria { get; set; }

        public string CorreoElectronico { get; set; }

        public string NumeroTelefono { get; set; }

        public string DireccionCliente { get; set; }
    }
}
