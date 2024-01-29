using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesGetPostDemoUI.Pages
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("Main Site Index OnGet() called");
        }

        public void OnPost()
        {
            _logger.LogInformation("Main site Index OnPost() called");
        }
    }
}
