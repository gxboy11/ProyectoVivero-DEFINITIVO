using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Categoria;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _service;

        public CategoriasController(ICategoriaService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var Categorias = _service.List();
            return View(Categorias);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevaCategoria());
        }

        [HttpPost]
        public IActionResult Insert(NuevaCategoria newCategoria)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newCategoria))
                {
                    ModelState.AddModelError(string.Empty, "La categoria no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newCategoria);
        }

        [HttpDelete]
        [Route("/api/v1/Categorias/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "La categoria no pudo ser eliminado" });
        }
    }
}
