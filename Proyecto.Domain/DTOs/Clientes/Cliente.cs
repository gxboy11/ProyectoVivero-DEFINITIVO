using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Clientes
{
    public class Cliente
    {


        public Cliente(int id, string nombreCliente, string apellidoCliente, string cedula, string correo, string telefono, string direccion1)
        {
            Id = id;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            CedulaCliente = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionCliente = direccion1;

        }

        public int Id { get; private set; }

        public string CedulaCliente { get; private set; }

        public string NombreCliente { get; private set; }

        public string ApellidoCliente { get; private set; }

        public string CorreoElectronico { get; private set; }

        public string NumeroTelefono { get; private set; }

        public string DireccionCliente { get; private set; }


        public bool HasChanged { get; private set; }

        public string FullName()
        {
            return NombreCliente + " " + ApellidoCliente;
        }

        public void Update(string nombreCliente, string apellidoCliente, string cedula, string correo, string telefono, string direccion)
        {
            HasChanged =
                !nombreCliente.Equals(NombreCliente, StringComparison.OrdinalIgnoreCase) &&
                !apellidoCliente.Equals(ApellidoCliente, StringComparison.OrdinalIgnoreCase) &&
                !cedula.Equals(CedulaCliente, StringComparison.OrdinalIgnoreCase) &&
                !correo.Equals(CorreoElectronico, StringComparison.OrdinalIgnoreCase) &&
                !telefono.Equals(NumeroTelefono, StringComparison.OrdinalIgnoreCase) &&
                !direccion.Equals(DireccionCliente, StringComparison.OrdinalIgnoreCase);

            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            CedulaCliente = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionCliente = direccion;
        }
    }
}
