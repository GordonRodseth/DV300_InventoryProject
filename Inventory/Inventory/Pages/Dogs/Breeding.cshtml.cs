#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inventory.Data;
using Inventory.Models;
using Inventory.Services;

namespace Inventory.Pages.Dogs
{
    public class BreedingModel : PageModel
    {
        private readonly Inventory.Data.InventoryContext _context;

        public BreedingModel(Inventory.Data.InventoryContext context)
        {
            _context = context;
        }


        public IList<Dog> Dog { get;set; }
        public IList<Breed> Breeds{ get; set; }

        public async Task OnGetAsync()
        {

            Breeds = new Models.Breeds().allBreeds;

            Dog = new Models.Dogs().allDogs;

            
            
        }
        
    }
}
