using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Producto;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.DTOs.Productos;

namespace Proyecto.Web.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoService _service;
        private readonly ICategoriaService _categoriaService;

        private static List<Producto> Carrito = new List<Producto>();

        public ProductosController(IProductoService service, ICategoriaService _categoriaService)
        {
            this._service = service;
            this._categoriaService = _categoriaService;
        }

        public IActionResult Index()
        {
            var Productos = _service.List();
            return View(Productos);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            var categorias = _categoriaService.List();
            ViewBag.Categorias = categorias;
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
