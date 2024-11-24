using Microsoft.AspNetCore.Mvc;

namespace WebApplication1MVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
