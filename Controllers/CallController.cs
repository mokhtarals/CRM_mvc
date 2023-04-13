using CRM_mvc.Context;
using CRM_mvc.Models.Entities;
using CRM_mvc.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers
{
	public class CallController : Controller
	{
		private ApplicationDbContext __context;
		public CallController(ApplicationDbContext context)
		{
			__context = context;
		}

		public IActionResult Index()
		{
			List<Call> calls = __context.Calls.Where(v => v.DeletedAt == null).ToList();
			CallViewModel model = new CallViewModel()
			{
				Calls = calls
			};
			return View(model);
		}

		public IActionResult Calling()
		{
			return View();
		}

		public IActionResult CallInformation()
		{
			return View();
		}

		public IActionResult CallPotentialCustomer()
		{
			return View();
		}

		public IActionResult EndCall()
		{
			return View();
		}
	}
}