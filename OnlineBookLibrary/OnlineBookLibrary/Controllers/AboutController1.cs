using Microsoft.AspNetCore.Mvc;

namespace OnlineBookLibrary.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 
