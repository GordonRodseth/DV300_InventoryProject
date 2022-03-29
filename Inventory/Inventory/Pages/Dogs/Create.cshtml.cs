#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Inventory.Data;
using Inventory.Models;
using Inventory.Services;

namespace Inventory.Pages.Dogs
{
    public class CreateModel : PageModel
    {
        private readonly Inventory.Data.InventoryContext _context;

        public CreateModel(Inventory.Data.InventoryContext context)
        {
            _context = context;


        }

        public IList<Breed> Breeds { get; set; }

        public IActionResult OnGet()
        {
            //Breeds= new List<Breed>();
            Breeds = new Models.Breeds().allBreeds;
            return Page();
        }

        [BindProperty]
        public Dog Dog { get; set; }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dog.Add(Dog);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");


        }

    }


}
