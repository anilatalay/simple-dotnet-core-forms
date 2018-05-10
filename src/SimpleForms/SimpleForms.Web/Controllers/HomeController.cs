using Microsoft.AspNetCore.Mvc;

namespace SimpleForms.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}