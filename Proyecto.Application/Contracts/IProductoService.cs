using Proyecto.Domain.DTOs.Productos;
using Proyecto.Domain.InputModels.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts
{
    public interface IProductoService
    {
        Producto Get(int id);

        List<Producto> List();

        bool Insert(NuevoProducto newProducto);

        bool Update(ProductoExistente productoExistente);

        bool Delete(int id);
    }
}
