using Microsoft.AspNetCore.Mvc;

namespace kitapModel.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
