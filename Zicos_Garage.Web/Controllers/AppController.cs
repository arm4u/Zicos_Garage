using Microsoft.AspNetCore.Mvc;

namespace Zicos_Garage.Web.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}