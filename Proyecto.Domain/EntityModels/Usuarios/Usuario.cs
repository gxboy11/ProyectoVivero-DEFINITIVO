using Proyecto.Domain.DTOs.Clientes;
using Proyecto.Domain.EntityModels.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Usuarios
{
    public class Usuario : Entity
    {
        public Usuario(string NombreUsuario, string PasswordUsuario, int? IdCliente, int? IdColaborador, bool IsAdmin)
        {
            this.NombreUsuario = NombreUsuario;
            this.PasswordUsuario = PasswordUsuario;
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
            this.IsAdmin = IsAdmin;
        }

        [Key]
        public int IdUsuario { get; private set; }

        public string NombreUsuario { get; private set; }

        public string PasswordUsuario { get; private set; }

        public int? IdCliente { get; private set; } //FK

        public int? IdColaborador { get; private set; } //FK

        public bool IsAdmin { get; private set; }


        /// <summary>
        /// Llaves Foraneas
        /// </summary>
        [ForeignKey(nameof(IdCliente))]
        public Cliente.Cliente Cliente { get; set; }

        [ForeignKey(nameof(IdColaborador))]
        public Colaboradores.Colaborador Colaborador { get; set; }



        public void Update(string NombreUsuario, string PasswordUsuario, int? IdCliente, int? IdColaborador, bool IsAdmin)
        {
            this.NombreUsuario = NombreUsuario;
            this.PasswordUsuario = PasswordUsuario;
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
            this.IsAdmin = IsAdmin;
        }
    }
}
