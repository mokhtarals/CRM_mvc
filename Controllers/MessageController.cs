using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GroupMessage()
        {
            return View();
        }
    }
}
