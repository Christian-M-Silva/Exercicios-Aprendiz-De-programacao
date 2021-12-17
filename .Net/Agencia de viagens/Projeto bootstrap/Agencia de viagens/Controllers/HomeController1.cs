using Microsoft.AspNetCore.Mvc;

namespace Agencia_de_viagens.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
