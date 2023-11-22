using Proyecto.Application.Contracts.Repositories;
using Proyecto.Application.Contracts;
using Entities = Proyecto.Domain.EntityModels.Categorias;
using Proyecto.Domain.InputModels.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.DTOs.Categorias;

namespace Proyecto.Application.Services
{
    public class CategoriaService : ICategoriaService
    {

        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository _repository)
        {
            this._repository = _repository;
        }

        public Categoria Get(int id)
        {
            var Categoria = _repository.Get(s => s.IdCategoria == id);
            return new Categoria(Categoria.IdCategoria, Categoria.NombreCategoria, Categoria.DescripcionCategoria);
        }

        public List<Categoria> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(Categoria => new Categoria(Categoria.IdCategoria, Categoria.NombreCategoria, Categoria.DescripcionCategoria));
        }


        public bool Insert(NuevaCategoria newCategoria)
        {
            Entities.Categoria Categoria = new Entities.Categoria(newCategoria.NombreCategoria, newCategoria.DescripcionCategoria);
            _repository.Insert(Categoria);
            _repository.Save();
            return true;
        }

        public bool Update(CategoriaExistente CategoriaExistente)
        {
            Entities.Categoria Categoria = _repository.Get(s => s.IdCategoria == CategoriaExistente.IdCategoria);
            Categoria.Update(CategoriaExistente.NombreCategoria, CategoriaExistente.DescripcionCategoria);
            _repository.Update(Categoria);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Categoria Categoria = _repository.Get(s => s.IdCategoria == id);
            _repository.Delete(Categoria);
            _repository.Save();
            return true;
        }
    }
}
