using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Cliff_Portfolio.ViewComponents
{
	public class BasisViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
