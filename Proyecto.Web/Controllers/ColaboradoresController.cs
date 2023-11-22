using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Colaborador;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Persistence.Migrations;

namespace Proyecto.Web.Controllers
{
    public class ColaboradoresController : Controller
    {
        private readonly IColaboradorService _service;

        public ColaboradoresController(IColaboradorService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var Colaboradores = _service.List();
            return View(Colaboradores);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevoColaborador());
        }

        [HttpPost]
        public IActionResult Insert(NuevoColaborador newColaborador)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newColaborador))
                {
                    ModelState.AddModelError(string.Empty, "Colaborador no pudo ser ingresado");
                }
                else
                {
                    HttpContext.Session.SetString("cedulaColaborador", newColaborador.CedulaColaborador);
                    return RedirectToAction("Insert", "Usuarios");
                }
            }
            return View(newColaborador);
        }

        [HttpDelete]
        [Route("/api/v1/Colaboradores/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "Colaborador no pudo ser eliminado" });
        }
    }
}
