using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Cliente
{
    public class Cliente : Entity
    {
        public Cliente(string nombreCliente, string apellidoCliente)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;

        }

        public void SetAdditionalInfo(string cedula, string correo, string telefono, string direccion) //Solucion a problema con Constructor de Cliente. +"No suitable constructor was found for entity type 'Cliente'.Cannot bind 'correoCliente', 'telefonoCliente' in 'Cliente(string nombreCliente,....

        {
            CedulaCliente = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionCliente = direccion;
        }


        public int Id { get; private set; }

        public string CedulaCliente { get; private set; }

        public string NombreCliente { get; private set; }

        public string ApellidoCliente { get; private set; }

        public string CorreoElectronico { get; private set; }

        public string NumeroTelefono { get; private set; }

        public string DireccionCliente { get; private set; }

        public void Update(string nombreCliente, string apellidoCliente, string cedula, string correo, string telefono, string direccion)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            CedulaCliente = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionCliente = direccion;
        }

    }
}
