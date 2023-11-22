using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Usuarios
{
    public class UsuarioExistente
    {
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string PasswordUsuario { get; set; }

        public int? IdCliente { get; set; }

        public int? IdColaborador { get; set; }

        public bool IsAdmin { get; set; }

    }
}
