using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Inventory.Models;
using Inventory.Services;

namespace Inventory.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IList<Dog> Dog { get; set; }
        public IList<Breed> Breeds { get; set; }

        public async Task OnGetAsync()
        {

            Breeds = new Models.Breeds().allBreeds;


            Dog = new Models.Dogs().allDogs;



        }

    }
}