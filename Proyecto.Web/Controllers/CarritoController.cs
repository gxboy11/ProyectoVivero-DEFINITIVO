using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    

public class CarritoController : Controller
{
    public IActionResult Index()
    {
        return View("Index"); // Puedes especificar el nombre de la vista si es diferente a la convención por defecto.
    }
}

}
