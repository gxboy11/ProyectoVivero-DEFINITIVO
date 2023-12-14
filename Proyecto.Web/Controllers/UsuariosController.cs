using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Application.Contracts;
using Proyecto.Application.Contracts.Contexts;
using Proyecto.Domain.EntityModels.Carritos;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.InputModels.Producto;
using Proyecto.Domain.InputModels.Usuarios;

namespace Proyecto.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _service;

        private readonly IColaboradorService _colaborador;
        private readonly IClienteService _cliente;
        private readonly IApplicationDbContext _context;

        private static List<int> _inMemoryCart = new List<int>();

        public UsuariosController(IUsuarioService service, IColaboradorService colaborador, IClienteService cliente)
        {
            this._service = service;
            this._colaborador = colaborador;
            this._cliente = cliente;
        }

        public IActionResult Index()
        {
            var users = _service.List();
            return View(users);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevoUsuario());
        }

        [HttpPost]
        public IActionResult Insert(NuevoUsuario newUser)
        {
            if (ModelState.IsValid)
            {
                var cedulaColaborador = HttpContext.Session.GetString("cedulaColaborador");
                var cedulaCliente = HttpContext.Session.GetString("cedulaCliente");


                if (!string.IsNullOrEmpty(cedulaColaborador))
                {
                    var colaborador = _colaborador.GetByCedula(cedulaColaborador);
                    newUser.IdColaborador = colaborador.Id;
                    newUser.IsAdmin = true;
                }

                if (!string.IsNullOrEmpty(cedulaCliente))
                {
                    var cliente = _cliente.GetByCedula(cedulaCliente);
                    newUser.IdCliente = cliente.Id;
                    newUser.IsAdmin = false;
                }

                if (!_service.Insert(newUser))
                {
                    ModelState.AddModelError(string.Empty, "Usuario no pudo ser ingresado");
                }
                else
                {
                    HttpContext.Session.Remove("cedulaColaborador");
                    HttpContext.Session.Remove("cedulaCliente");
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(newUser);
        }

        [HttpPost]
        public ActionResult AddToCart(int productId)
        {
            if (ModelState.IsValid)
            {
                int userId = HttpContext.Session.GetInt32("idUser").Value;

                _service.AddToCart(userId, productId);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewCart(int userId)
        {
            var productosEnCarrito = _service.GetUserCart(userId);

            // Corrige la creación de la lista de Carrito
            var carritos = productosEnCarrito.Select(p => new Carrito(userId, p.IdProducto)).ToList();

            return View(carritos);
        }

        [HttpDelete]
        [Route("/api/v1/usuarios/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "Usuario no pudo ser eliminado" });
        }
    }
}
