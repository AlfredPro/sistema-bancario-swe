using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BankTransfer.Models;

namespace BankTransfer.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    public class LoginModel : PageModel
    {
        [BindProperty]
        public UserData UserData { get; set; }

        public void OnGet()
        {

        }
    }
}
