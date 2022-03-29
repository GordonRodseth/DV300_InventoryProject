#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;
using Inventory.Services;

namespace Inventory.Data
{
    public class InventoryContext : DbContext
    {
       // public List<Breed> Breeds=new List<Breed>();
        //public List<Breed> GetBreeds()
        //{
            //var Breeds = Services.Database.GetAllBreeds();
          //  return Breeds;
        //}

        public InventoryContext (DbContextOptions<InventoryContext> options)
            : base(options)
        {

        }

        public DbSet<Inventory.Models.Dog>? Dog { get; set; }

    }


}
