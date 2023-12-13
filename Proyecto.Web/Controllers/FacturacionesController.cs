using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Facturacion;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    public class FacturacionesController : Controller
    {
        private readonly IFacturacionService _service;

        public FacturacionesController(IFacturacionService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var Facturaciones = _service.List();
            return View(Facturaciones);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevaFacturacion());
        }

        [HttpPost]
        public IActionResult Insert(NuevaFacturacion newFacturacion)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newFacturacion))
                {
                    ModelState.AddModelError(string.Empty, "La facturacion no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newFacturacion);
        }

        [HttpDelete]
        [Route("/api/v1/Facturaciones/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "La facturacion no pudo ser eliminado" });
        }
    }
}
