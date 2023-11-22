using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Colaborador
{
    public class ColaboradorExistente
    {
        public int Id { get; set; }

        public string CedulaColaborador { get; set; }

        public string NombreColaborador { get; set; }

        public string ApellidoColaborador { get; set; }

        public string CorreoElectronico { get; set; }

        public string NumeroTelefono { get; set; }

        public string DireccionColaborador { get; set; }

        public float SalarioColaborador { get; set; }
    }
}
