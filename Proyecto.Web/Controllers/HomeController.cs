using Proyecto.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Proyecto.Domain.InputModels.Cliente;
using Proyecto.Application.Contracts;

namespace Proyecto.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductoService _service;

        public HomeController(IProductoService service)
        {
            this._service = service;
        }
        public IActionResult Index()
        {
            var Productos = _service.List();
            return View(Productos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}