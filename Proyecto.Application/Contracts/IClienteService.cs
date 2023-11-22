using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.DTOs.Clientes;
using Proyecto.Domain.InputModels.Cliente;

namespace Proyecto.Application.Contracts
{
    public interface IClienteService
    {
        Cliente Get(int id);

        Cliente GetByCedula(string cedula);

        List<Cliente> List();

        bool Insert(NuevoCliente newCliente);

        bool Update(ClienteExistente existingCliente);

        bool Delete(int id);
    }
}
