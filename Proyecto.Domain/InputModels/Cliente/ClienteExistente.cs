using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Cliente
{
    public class ClienteExistente
    {
        public int Id { get; set; }

        public string CedulaCliente { get; set; }

        public string NombreCliente { get; set; }

        public string ApellidoCliente { get; set; }

        public string CorreoElectronico { get; set; }

        public string NumeroTelefono { get; set; }

        public string DireccionCliente { get; set; }
    }
}
