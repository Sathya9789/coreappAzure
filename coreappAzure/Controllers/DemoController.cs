using Microsoft.AspNetCore.Mvc;

namespace coreappAzure.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
