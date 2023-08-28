using Microsoft.AspNetCore.Mvc;

namespace OtomasyonProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
