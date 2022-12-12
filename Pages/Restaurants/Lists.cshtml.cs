using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
namespace OdoFood.Pages.Restaurants
{
    public class ListsModel : PageModel
    {
        private readonly IConfiguration config;
        public string Message { get; set; }
        public ListsModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}
