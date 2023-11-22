using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.DTOs.Colaboradores
{
    public class Colaborador
    {
        public Colaborador(int id, string nombreColaborador, string apellidoColaborador, string cedula, string correo, string telefono, string direccion, float salario)
        {
            Id = id;
            NombreColaborador = nombreColaborador;
            ApellidoColaborador = apellidoColaborador;
            CedulaColaborador = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionColaborador = direccion;
            SalarioColaborador = salario;
        }

        public int Id { get; private set; }

        public string CedulaColaborador { get; private set; }

        public string NombreColaborador { get; private set; }

        public string ApellidoColaborador { get; private set; }

        public string CorreoElectronico { get; private set; }

        public string NumeroTelefono { get; private set; }

        public string DireccionColaborador { get; private set; }

        public float SalarioColaborador { get; private set; }

        public bool HasChanged { get; private set; }

        public string FullName()
        {
            return NombreColaborador + " " + ApellidoColaborador;
        }

        public void Update(string nombreColaborador, string apellidoColaborador, string cedula, string correo, string telefono, string direccion, float salario)
        {
            HasChanged =
                !nombreColaborador.Equals(NombreColaborador, StringComparison.OrdinalIgnoreCase) &&
                !apellidoColaborador.Equals(ApellidoColaborador, StringComparison.OrdinalIgnoreCase) &&
                !cedula.Equals(CedulaColaborador, StringComparison.OrdinalIgnoreCase) &&
                !correo.Equals(CorreoElectronico, StringComparison.OrdinalIgnoreCase) &&
                !telefono.Equals(NumeroTelefono, StringComparison.OrdinalIgnoreCase) &&
                !direccion.Equals(DireccionColaborador, StringComparison.OrdinalIgnoreCase);

            NombreColaborador = nombreColaborador;
            ApellidoColaborador = apellidoColaborador;
            CedulaColaborador = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionColaborador = direccion;
            SalarioColaborador = salario;
        }
    }
}
