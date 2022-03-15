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

namespace Inventory.Pages.Dogs
{
    public class IndexModel : PageModel
    {
        private readonly Inventory.Data.InventoryContext _context;

        public IndexModel(Inventory.Data.InventoryContext context)
        {
            _context = context;
        }


        public IList<Dog> Dog { get;set; }

        public IList<Breed> Breed{ get; set; }

        public async Task OnGetAsync()
        {
            Breed[] breeds;
            breeds = _context.GetBreeds();
            ViewData["Purebreeds"] = breeds;

            Dog = await _context.Dog.ToListAsync();
        }
    }
}
