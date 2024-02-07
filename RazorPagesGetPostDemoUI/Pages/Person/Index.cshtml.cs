using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostDemoUI.Models;

namespace RazorPagesGetPostDemoUI.Pages.Person
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {

        private ILogger<IndexModel> _logger;
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public PersonInfo CurrentPerson { get; set; } = new();
        public void OnGet()
        {
            _logger.LogInformation("INDEX ONPOST called");

        }
        public void OnPost()
        {
            _logger.LogInformation("INDEX ONPOST called");
        }
    }
}
