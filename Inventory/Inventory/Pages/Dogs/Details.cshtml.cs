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
    public class DetailsModel : PageModel
    {
        private readonly Inventory.Data.InventoryContext _context;

        public DetailsModel(Inventory.Data.InventoryContext context)
        {
            _context = context;
        }

        public Dog Dog { get; set; }

        

        public async Task<IActionResult> OnGetAsync(int id)
        {


            Dog = new Models.Dogs(id).selectdog;

            if (Dog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
