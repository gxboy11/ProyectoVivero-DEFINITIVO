using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.DTOs.Usuarios;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.InputModels.Producto;
using Proyecto.Domain.InputModels.Usuarios;

namespace Proyecto.Application.Contracts
{
    public interface IUsuarioService
    {
        Usuario Get(int id);

        int GetUserByCredentials(string username, string password);

        bool IsCredentialValid(string nombre, string password);

        List<Usuario> List();

        bool Insert(NuevoUsuario user);

        bool Update(UsuarioExistente user);

        bool Delete(int id);

        bool AddToCart(int userId, int productId);

        bool DeleteFromCart(int userId, int productId);

        List<Producto> GetUserCart(int userId);
    }
}
