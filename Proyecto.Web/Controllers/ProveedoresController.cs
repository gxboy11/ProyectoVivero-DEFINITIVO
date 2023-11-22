using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Proveedor;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly IProveedorService _service;

        public ProveedoresController(IProveedorService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var Proveedoress = _service.List();
            return View(Proveedoress);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevoProveedor());
        }

        [HttpPost]
        public IActionResult Insert(NuevoProveedor newProveedores)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newProveedores))
                {
                    ModelState.AddModelError(string.Empty, "El Proveedor no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newProveedores);
        }

        [HttpDelete]
        [Route("/api/v1/proveedores/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "El proveedor no pudo ser eliminado" });
        }
    }
}
