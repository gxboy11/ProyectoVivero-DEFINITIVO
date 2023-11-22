using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Usuarios
{
    public class Usuario
    {
        public Usuario(int IdUsuario, string NombreUsuario, string PasswordUsuario, int? IdCliente, int? IdColaborador, bool IsAdmin)
        {
            this.IdUsuario = IdUsuario;
            this.NombreUsuario = NombreUsuario;
            this.PasswordUsuario = PasswordUsuario;
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
            this.IsAdmin = IsAdmin;
        }

        public int IdUsuario { get; private set; }

        public string NombreUsuario { get; private set; }

        public string PasswordUsuario { get; private set; }

        public int? IdCliente { get; private set; }

        public int? IdColaborador { get; private set; }

        public bool IsAdmin { get; private set; }

        public bool HasChanged { get; private set; }

        public void Update(string NombreUsuario, string PasswordUsuario, int? IdPersona, bool IsAdmin)
        {
            HasChanged =
                !NombreUsuario.Equals(this.NombreUsuario, StringComparison.OrdinalIgnoreCase) &&
                !PasswordUsuario.Equals(this.PasswordUsuario, StringComparison.OrdinalIgnoreCase);

            this.NombreUsuario = NombreUsuario;
            this.PasswordUsuario = PasswordUsuario;
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
            this.IsAdmin = IsAdmin;
        }
    }
}
