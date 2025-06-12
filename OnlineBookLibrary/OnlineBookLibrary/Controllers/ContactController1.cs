using Microsoft.AspNetCore.Mvc;

namespace OnlineBookLibrary.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
