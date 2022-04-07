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

        public IList<Dog> Dogs { get; set; }
        public IList<Breed> Breeds { get; set; }


        public async Task OnGetAsync()
        {

            Breeds = new Models.Breeds().allBreeds;



        }

        [BindProperty]
        public Dog Dog { get; set; }

        public RedirectToPageResult OnPostAdopt(string name, int breedid, int motherid, int fatherid, int kennelid, string pedigree, string sex)
        {
            
            Database.AddDog(name, breedid, motherid, fatherid, kennelid, pedigree,sex);

            return RedirectToPage("./Index");


        }

    }


}
