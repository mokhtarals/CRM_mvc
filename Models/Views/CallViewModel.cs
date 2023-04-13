using CRM_mvc.Models.Entities;

namespace CRM_mvc.Models.Views
{
	public class CallViewModel
	{
		public List<Call> Calls { get; set; }
		public NewCallViewModel? NewCall { get; set; }
	}

	public class NewCallViewModel
	{
	}
}
