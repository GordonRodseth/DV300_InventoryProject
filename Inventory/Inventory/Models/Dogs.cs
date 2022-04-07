using Inventory.Services;
using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public class Dogs
    {
        public List<Dog> allDogs = new List<Dog>();


        public Dogs()
        {
            allDogs = Database.GetAllDogs();

        }

        public Dog selectdog=new Dog();

        public Dogs(int id)
        {
            selectdog = Database.SelectDog(id);
        }

        public void Delete(int dogid)
        {
            Database.DeleteDog(dogid);
        }

        public void Edit(int dogid, string name, int kennelid)
        {
            Database.EditDog(dogid, name, kennelid);
        }

        public void Add(string name, int breedid, int motherid, int fatherid, int kennelid, string pedigree,string sex)
        {
            Database.AddDog(name, breedid, motherid, fatherid, kennelid, pedigree,sex);
        }


    }
}