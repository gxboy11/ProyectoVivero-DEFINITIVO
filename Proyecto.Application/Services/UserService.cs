using Proyecto.Application.Contracts;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.DTOs.Usuarios;
using Entities = Proyecto.Domain.EntityModels.Usuarios;
using Proyecto.Domain.InputModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Application.Contracts.Contexts;
using Proyecto.Domain.InputModels.Producto;
using System.ComponentModel.DataAnnotations;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.EntityModels.Carritos;

namespace Proyecto.Application.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _repository;
        private readonly IApplicationDbContext _context;

        public UsuarioService(IUsuarioRepository _repository, IApplicationDbContext _context)
        {
            this._repository = _repository;
            this._context = _context;
        }
        public Usuario Get(int id)
        {
            var user = _repository.Get(s => s.IdUsuario == id);
            return new Usuario(user.IdUsuario, user.NombreUsuario, user.PasswordUsuario, user.IdCliente, user.IdColaborador, user.IsAdmin);
        }

        public List<Usuario> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(user => new Usuario(user.IdUsuario, user.NombreUsuario, user.PasswordUsuario, user.IdCliente, user.IdColaborador, user.IsAdmin));
        }

        public bool Insert(NuevoUsuario newUsuario)
        {
            Entities.Usuario user = new Entities.Usuario(newUsuario.NombreUsuario, newUsuario.PasswordUsuario, newUsuario.IdCliente, newUsuario.IdColaborador, newUsuario.IsAdmin, 0);
            _repository.Insert(user);
            _repository.Save();
            return true;
        }

        public bool Update(UsuarioExistente existingUsuario)
        {
            Entities.Usuario user = _repository.Get(s => s.IdUsuario == existingUsuario.IdUsuario);
            user.Update(existingUsuario.NombreUsuario, existingUsuario.PasswordUsuario, existingUsuario.IdCliente, existingUsuario.IdColaborador, existingUsuario.IsAdmin);
            _repository.Update(user);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Usuario user = _repository.Get(s => s.IdUsuario == id);
            _repository.Delete(user);
            _repository.Save();
            return true;
        }

        public bool IsCredentialValid(string nombreUsuario, string password)
        {
            var usuarioRegistrado = _repository.Get(s => s.NombreUsuario == nombreUsuario);

            if (usuarioRegistrado != null)
            {
                if (usuarioRegistrado.PasswordUsuario == password)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetUserByCredentials(string username, string password)
        {

            var user = _context.Usuarios.SingleOrDefault(u => u.NombreUsuario == username && u.PasswordUsuario == password);

            if (user != null)
            {
                return user.IdUsuario;
            }

            return -1;
        }

        public bool AddToCart(int userId, int productId)
        {
            var user = _repository.Get(s => s.IdUsuario == userId);

            if (user != null)
            {
                var productToAdd = _context.Productos.SingleOrDefault(p => p.IdProducto == productId);

                if (productToAdd != null)
                {
                    var existingRelation = user.Carrito.SingleOrDefault(up => up.ProductoId == productId);

                    if (existingRelation == null)
                    {
                        // Si no existe, crear una nueva relación con la cantidad proporcionada
                        var newRelation = new Carrito(userId, productId);

                        user.Carrito.Add(newRelation);
                    }

                    _repository.Update(user);
                    _repository.Save();

                    return true;
                }
            }

            return false;
        }



        public bool DeleteFromCart(int userId, int productId)
        {
            Entities.Usuario user = _repository.Get(s => s.IdUsuario == userId);

            if (user != null)
            {
                // Buscar el producto
                var productToDelete = user.Carrito.SingleOrDefault(p => p.Id == productId);

                if (productToDelete != null)
                {
                    user.Carrito.Remove(productToDelete);
                }

                _repository.Update(user);
                _repository.Save();
                return true;
            }
            return false;
        }

        public List<Producto> GetUserCart(int userId)
        {
            var user = _repository.Get(s => s.IdUsuario == userId);

            if (user != null && user.Carrito != null && user.Carrito.Any())
            {
                var productosEnCarrito = user.Carrito.Select(up => up.Producto).ToList();
                return productosEnCarrito;
            }

            return new List<Producto>();
        }

    }



}

