using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AskForSession()
        {
            return View();
        }

        public IActionResult ConfirmSession()
        {
            return View();
        }

        public IActionResult Conversation()
        {
            return View();
        }
    }
}
