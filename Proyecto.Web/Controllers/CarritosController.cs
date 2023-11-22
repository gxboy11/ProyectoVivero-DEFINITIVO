using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{

    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }

}