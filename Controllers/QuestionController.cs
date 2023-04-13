using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Answers()
        {
            return View();
        }
    }
}
