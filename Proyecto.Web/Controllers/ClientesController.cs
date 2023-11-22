using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _service;

        public ClientesController(IClienteService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var clientes = _service.List();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevoCliente());
        }

        [HttpPost]
        public IActionResult Insert(NuevoCliente newCliente)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newCliente))
                {
                    ModelState.AddModelError(string.Empty, "Cliente no pudo ser ingresado");
                }
                else
                {
                    HttpContext.Session.SetString("cedulaCliente", newCliente.CedulaCliente);
                    return RedirectToAction("Insert", "Usuarios");
                }
            }
            return View(newCliente);
        }

        [HttpDelete]
        [Route("/api/v1/clientes/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "Cliente no pudo ser eliminado" });
        }
    }
}
