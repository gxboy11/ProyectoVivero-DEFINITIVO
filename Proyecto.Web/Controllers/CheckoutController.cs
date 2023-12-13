using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Web.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
