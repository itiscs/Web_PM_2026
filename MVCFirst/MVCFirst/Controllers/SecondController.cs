using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Feedback(string id)
        {
            if (id != null)
                @ViewData["Name"] = id;
            return View();
        }
    }
}
