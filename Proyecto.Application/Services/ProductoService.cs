using Proyecto.Application.Contracts;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.DTOs.Productos;
using Entities = Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.InputModels.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository _repository)
        {
            this._repository = _repository;
        }

        public Producto Get(int id)
        {
            var producto = _repository.Get(s => s.IdProducto == id);
            return new Producto(producto.IdProducto, producto.NombreProducto, producto.DescripcionProducto,
                producto.IdCategoria, producto.PrecioProducto, producto.ImagenProducto);
        }
        
        public List<Producto> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(producto => new Producto(producto.IdProducto, producto.NombreProducto, producto.DescripcionProducto,
                producto.IdCategoria, producto.PrecioProducto, producto.ImagenProducto));
        }

        public bool Insert(NuevoProducto newProducto)
        {
            Entities.Producto producto = new Entities.Producto(newProducto.NombreProducto, newProducto.DescripcionProducto, newProducto.IdCategoria, newProducto.PrecioProducto, newProducto.ImagenProducto);
            _repository.Insert(producto);
            _repository.Save();
            return true;
        }

        public bool Update(ProductoExistente productoExistente)
        {
            Entities.Producto producto = _repository.Get(s => s.IdProducto == productoExistente.IdProducto);
            producto.Update(productoExistente.NombreProducto, productoExistente.DescripcionProducto, productoExistente.IdCategoria, productoExistente.PrecioProducto, productoExistente.ImagenProducto);
            _repository.Update(producto);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Producto producto = _repository.Get(s => s.IdProducto == id);
            _repository.Delete(producto);
            _repository.Save();
            return true;
        }
    }
}
