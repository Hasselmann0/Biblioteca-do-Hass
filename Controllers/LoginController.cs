using Microsoft.AspNetCore.Mvc;

namespace BibliotecaDoHass.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View(); 
        }
    }
}
