using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostDemoUI.Models;

namespace RazorPagesGetPostDemoUI.Pages.Person
{
    [BindProperties(SupportsGet = true)]
    public class AddInfoModel : PageModel
    {
        private readonly ILogger<AddInfoModel> _logger;
        public AddInfoModel(ILogger<AddInfoModel> logger)
        {
            _logger = logger;
        }
        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new(); // can use new if the type is mentioned on the left
        public void OnGet()
        { 
        
            _logger.LogInformation("ONGET called in ADDINFO page");
        }
        public IActionResult OnPost()
        {
            _logger.LogInformation("ONPOST called in ADDINFO page");
            if(ModelState.IsValid)
            {
                return RedirectToPage("./Index", CurrentPerson);
            }
            else
            {
                return Page();
            }
        }
    }   
}