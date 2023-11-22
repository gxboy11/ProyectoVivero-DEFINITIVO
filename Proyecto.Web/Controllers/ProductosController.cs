using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Producto;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoService _service;

        public ProductosController(IProductoService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var Productos = _service.List();
            return View(Productos);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevoProducto());
        }

        [HttpPost]
        public IActionResult Insert(NuevoProducto newProducto)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newProducto))
                {
                    ModelState.AddModelError(string.Empty, "Producto no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newProducto);
        }

        [HttpDelete]
        [Route("/api/v1/Productos/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "Producto no pudo ser eliminado" });
        }
    }
}
