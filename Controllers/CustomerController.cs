using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CustomerInformation()
    {
        return View();
    }
}