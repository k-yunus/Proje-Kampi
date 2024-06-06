using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampi.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
