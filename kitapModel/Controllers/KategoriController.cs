using Microsoft.AspNetCore.Mvc;

namespace kitapModel.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
