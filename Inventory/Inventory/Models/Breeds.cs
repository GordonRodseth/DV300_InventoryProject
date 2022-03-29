using Inventory.Services;
using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public class Breeds
    {
        public List<Breed> allBreeds = new List<Breed>();

        public Breeds()
        {
            allBreeds = Database.GetAllBreeds();
        }

    }
}
