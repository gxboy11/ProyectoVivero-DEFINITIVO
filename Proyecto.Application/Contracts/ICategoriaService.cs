using Proyecto.Domain.DTOs.Categorias;
using Proyecto.Domain.InputModels.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts
{
    public interface ICategoriaService
    {
        Categoria Get(int id);

        List<Categoria> List();

        bool Insert(NuevaCategoria newCategoria);

        bool Update(CategoriaExistente existingCategoria);

        bool Delete(int id);
    }
}
