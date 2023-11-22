using Proyecto.Domain.DTOs.Facturaciones;
using Proyecto.Domain.InputModels.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts
{
    public interface IFacturacionService
    {
        Facturacion Get(int id);

        List<Facturacion> List();

        bool Insert(NuevaFacturacion newFacturacion);

        bool Update(FacturacionExistente existingFacturacion);

        bool Delete(int id);
    }
}
