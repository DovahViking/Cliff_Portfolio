using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cliff_Portfolio.Pages.Portfolios.Game_Developer
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

		public IActionResult OnGetSection(string section)
		{
			return ViewComponent("GameDevelopment", section);
		}
	}
}
