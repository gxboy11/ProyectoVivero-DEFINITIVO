using Proyecto.Domain.DTOs.Proveedores;
using Proyecto.Domain.InputModels.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts
{
    public interface IProveedorService
    {
        Proveedor Get(int id);

        List<Proveedor> List();

        bool Insert(NuevoProveedor newProveedor);

        bool Update(ProveedorExistente existingProveedor);

        bool Delete(int id);
    }
}
