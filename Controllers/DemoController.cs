using Microsoft.AspNetCore.Mvc;

namespace btt2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
