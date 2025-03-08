using Microsoft.AspNetCore.Mvc;

namespace CarsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
