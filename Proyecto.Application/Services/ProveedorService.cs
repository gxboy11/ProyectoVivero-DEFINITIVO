using Proyecto.Application.Contracts.Repositories;
using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Proveedor;
using Entities = Proyecto.Domain.EntityModels.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.DTOs.Proveedores;

namespace Proyecto.Application.Services
{
    public class ProveedorService : IProveedorService
    {

        private readonly IProveedorRepository _repository;

        public ProveedorService(IProveedorRepository _repository)
        {
            this._repository = _repository;
        }

        public Proveedor Get(int id)
        {
            var Proveedor = _repository.Get(s => s.IdProveedor == id);
            return new Proveedor(Proveedor.IdProveedor, Proveedor.NombreProveedor, Proveedor.CorreoProveedor,
                Proveedor.DireccionProveedor);
        }

        public List<Proveedor> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(Proveedor => new Proveedor(Proveedor.IdProveedor, Proveedor.NombreProveedor, Proveedor.CorreoProveedor,
                Proveedor.DireccionProveedor));
        }


        public bool Insert(NuevoProveedor newProveedor)
        {
            Entities.Proveedor Proveedor = new Entities.Proveedor(newProveedor.NombreProveedor, newProveedor.CorreoProveedor, newProveedor.DireccionProveedor);
            _repository.Insert(Proveedor);
            _repository.Save();
            return true;
        }

        public bool Update(ProveedorExistente ProveedorExistente)
        {
            Entities.Proveedor Proveedor = _repository.Get(s => s.IdProveedor == ProveedorExistente.IdProveedor);
            Proveedor.Update(ProveedorExistente.NombreProveedor, ProveedorExistente.CorreoProveedor, ProveedorExistente.DireccionProveedor);
            _repository.Update(Proveedor);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Proveedor Proveedor = _repository.Get(s => s.IdProveedor == id);
            _repository.Delete(Proveedor);
            _repository.Save();
            return true;
        }
    }
}
