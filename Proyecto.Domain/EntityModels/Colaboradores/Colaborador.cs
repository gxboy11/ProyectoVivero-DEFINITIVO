using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Colaboradores
{
    public class Colaborador : Entity
    {
        public Colaborador(string nombreColaborador, string apellidoColaborador)
        {
            NombreColaborador = nombreColaborador;
            ApellidoColaborador = apellidoColaborador;
        }

        public void SetAdditionalInfo(string cedula, string correo, string telefono, string direccion, float salario)
        {
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

        public void Update(string nombreColaborador, string apellidoColaborador, string cedula, string correo, string telefono, string direccion, float salario)
        {
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
