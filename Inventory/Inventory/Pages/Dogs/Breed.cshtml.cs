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


using Microsoft.EntityFrameworkCore;



namespace Inventory.Pages.Dogs
{
    public class BreedModel : PageModel
    {
        private readonly Inventory.Data.InventoryContext _context;

        public BreedModel(Inventory.Data.InventoryContext context)
        {
            _context = context;


        }

        public IList<Breed> Breeds { get; set; }
        public IList<Dog> Dogs { get;set; }



        public IActionResult OnGet(string id, string parent1, string parent2)
        {
            //Breeds= new List<Breed>();
            Breeds = new Models.Breeds().allBreeds;
            Dogs = new Models.Dogs().allDogs;
            //int breed = newdogbreed;
            ViewData["breed"] = id;
            ViewData["Parent1"] = parent1;
            ViewData["Parent2"]= parent2;
            return  Page();
        }

        [BindProperty]
        public Dog Dog { get; set; }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public RedirectToPageResult OnPostBreed(string name, int breedid, int motherid, int fatherid, int kennelid, string pedigree, string sex, int licensenum, string username, string usersurname)
        {
            var usercheck = Database.VerifyUser(licensenum, username, usersurname);

            if(usercheck)
            {
                Database.AddDog(name, breedid, motherid, fatherid, kennelid, pedigree,sex);
            }
            else
            {
                return RedirectToPage("./Index");
            };
            

            return RedirectToPage("./Index");


        }

    }


}
