using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendEmail()
        {
            return View();
        }
    }
}
