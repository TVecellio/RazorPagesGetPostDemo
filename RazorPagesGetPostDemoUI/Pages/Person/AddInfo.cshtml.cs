using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostDemoUI.Models;

namespace RazorPagesGetPostDemoUI.Pages.Person
{
    [BindProperties(SupportsGet = true)]
    public class AddInfoModel : PageModel
    {
        private readonly ILogger<AddInfoModel> _logger;

        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new(); // can use new if the type is mentioned on the left
        public void OnGet()
        {
        }
        public IActionResult onPost()
        {
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