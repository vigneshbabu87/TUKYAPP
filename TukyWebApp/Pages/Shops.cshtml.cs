using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TukyWebApp.Pages
{
    public class ShopsModel : PageModel
    {
        private readonly ILogger<ShopsModel> _logger;

        public ShopsModel(ILogger<ShopsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
      
    }
}
