using Proyecto.Application.Contracts.Repositories;
using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Facturacion;
using Entities = Proyecto.Domain.EntityModels.Facturaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.DTOs.Facturaciones;
using Proyecto.Domain.InputModels.Cliente;

namespace Proyecto.Application.Services
{
    public class FacturacionService : IFacturacionService
    {

        private readonly IFacturacionRepository _repository;

        public FacturacionService(IFacturacionRepository _repository)
        {
            this._repository = _repository;
        }

        public Facturacion Get(int id)
        {
            var Facturacion = _repository.Get(s => s.IdFacturacion == id);
            return new Facturacion(Facturacion.IdFacturacion, Facturacion.IdProducto, Facturacion.IdUsuario,
                Facturacion.PrecioTotal);
        }

        public List<Facturacion> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(Facturacion => new Facturacion(Facturacion.IdFacturacion, Facturacion.IdProducto, Facturacion.IdUsuario,
                Facturacion.PrecioTotal));
        }


        public bool Insert(NuevaFacturacion newFacturacion)
        {
            Entities.Facturacion Facturacion = new Entities.Facturacion(newFacturacion.IdProducto,newFacturacion.IdUsuario);
            Facturacion.SetAdditionalInfo(newFacturacion.PrecioTotal);
            _repository.Insert(Facturacion);
            _repository.Save();
            return true;
        }

        public bool Update(FacturacionExistente FacturacionExistente)
        {
            Entities.Facturacion Facturacion = _repository.Get(s => s.IdFacturacion == FacturacionExistente.IdFacturacion);
            Facturacion.Update(FacturacionExistente.IdProducto, FacturacionExistente.IdUsuario, FacturacionExistente.PrecioTotal);
            _repository.Update(Facturacion);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Facturacion Facturacion = _repository.Get(s => s.IdFacturacion == id);
            _repository.Delete(Facturacion);
            _repository.Save();
            return true;
        }
    }
}
