using Microsoft.AspNetCore.Mvc;

namespace Cliff_Portfolio.ViewComponents
{
	public class GameDevelopmentViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(string section_name)
		{
			return View(section_name);
		}
	}
}