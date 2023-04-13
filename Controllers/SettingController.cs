using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }

        public IActionResult Permissions()
        {
            return View();
        }

        public IActionResult UserInformation()
        {
            return View();
        }
    }
}
