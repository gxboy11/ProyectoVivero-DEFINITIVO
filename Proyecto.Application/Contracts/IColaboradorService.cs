using Proyecto.Domain.DTOs.Colaboradores;
using Proyecto.Domain.InputModels.Colaborador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts
{
    public interface IColaboradorService
    {
        Colaborador Get(int id);

        Colaborador GetByCedula(string cedula);

        List<Colaborador> List();

        bool Insert(NuevoColaborador newColaborador);

        bool Update(ColaboradorExistente existingColaborador);

        bool Delete(int id);
    }
}
