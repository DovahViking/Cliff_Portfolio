using Microsoft.AspNetCore.Mvc;

namespace Cliff_Portfolio.ViewComponents
{
	public class SoftwareDevelopmentViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(string section_name)
		{
			return View(section_name);
		}
	}
}
