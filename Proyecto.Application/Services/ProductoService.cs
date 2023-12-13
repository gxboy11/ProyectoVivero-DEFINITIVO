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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Proyecto.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IHostingEnvironment _webHostEnvironment;

        public ProductoService(IProductoRepository _repository, IHostingEnvironment _webHostEnvironment)
        {
            this._repository = _repository;
            this._webHostEnvironment = _webHostEnvironment;
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
            string imgPath = ProcessImg(newProducto.ImagenProducto);

            Entities.Producto producto = new Entities.Producto(newProducto.NombreProducto, newProducto.DescripcionProducto, newProducto.IdCategoria, newProducto.PrecioProducto, imgPath);
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

        public string ProcessImg(IFormFile imageFile)
        {
            string filename = "";
            if (imageFile != null)
            {
                // Logica para guardar la ruta del folder wwwroot/images
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                filename = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                string filepath = Path.Combine(uploadFolder, filename);

                //Guarda la imagen
                imageFile.CopyTo(new FileStream(filepath, FileMode.Create));

            }
            return filename;
        }
    }
}
