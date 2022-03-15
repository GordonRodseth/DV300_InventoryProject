#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;

namespace Inventory.Data
{
    public class InventoryContext : DbContext
    {
        public Breed[] GetBreeds()
        {


            Breed AusCattle = new Breed()
            {
                Id = 0,
                BreedName = "Australian Cattle Dog",
                ImgUrl = "/img/Aus_Cattle_Dog.png",
                Parent1BreedId = 0,
                Parent2BreedId = 0,
            };

            Breed AusShep = new Breed()
            {
                Id = 1,
                BreedName = "Australian Shepherd",
                ImgUrl = "/img/Aussie_shepherd.png",
                Parent1BreedId = 1,
                Parent2BreedId = 1,
            };

            Breed Beagle = new Breed()
            {
                Id = 2,
                BreedName = "Beagle",
                ImgUrl = "/img/Beagle.png",
                Parent1BreedId = 2,
                Parent2BreedId = 2,
            };

            Breed Bichon = new Breed()
            {
                Id = 3,
                BreedName = "Bichon Frise",
                ImgUrl = "/img/bichon_frise.png",
                Parent1BreedId = 3,
                Parent2BreedId = 3,
            };

            Breed Chihuahua = new Breed()
            {
                Id = 4,
                BreedName = "Chihuahua",
                ImgUrl = "/img/Chihuahua.png",
                Parent1BreedId = 4,
                Parent2BreedId = 4,
            };

            Breed CockerSpaniel = new Breed()
            {
                Id = 5,
                BreedName = "Cocker Spaniel",
                ImgUrl = "/img/Cocker_Spaniel.png",
                Parent1BreedId = 5,
                Parent2BreedId = 5,
            };

            Breed Collie = new Breed()
            {
                Id = 6,
                BreedName = "Border Collie",
                ImgUrl = "/img/Collie.png",
                Parent1BreedId = 6,
                Parent2BreedId = 6,
            };

            Breed Corgi = new Breed()
            {
                Id = 7,
                BreedName = "Corgi",
                ImgUrl = "/img/Corgi.png",
                Parent1BreedId = 7,
                Parent2BreedId = 7,
            };

            Breed Daschund = new Breed()
            {
                Id = 8,
                BreedName = "Daschund",
                ImgUrl = "/img/Daschund.png",
                Parent1BreedId = 8,
                Parent2BreedId = 8,
            };

            Breed EngSpringerSpaniel = new Breed()
            {
                Id = 9,
                BreedName = "English Springer Spaniel",
                ImgUrl = "/img/English_Springer_Spaniel.png",
                Parent1BreedId = 9,
                Parent2BreedId = 9,
            };

            Breed GermanShep = new Breed()
            {
                Id = 10,
                BreedName = "German Shepherd",
                ImgUrl = "/img/german_shepherd.png",
                Parent1BreedId = 10,
                Parent2BreedId = 10,
            };

            Breed Goldie = new Breed()
            {
                Id = 11,
                BreedName = "Golden Retriever",
                ImgUrl = "/img/Golden_Retriever.png",
                Parent1BreedId = 11,
                Parent2BreedId = 11,
            };

            Breed Greyhound = new Breed()
            {
                Id = 12,
                BreedName = "Greyhound",
                ImgUrl = "/img/Greyhound.png",
                Parent1BreedId = 12,
                Parent2BreedId = 12,
            };

            Breed Husky = new Breed()
            {
                Id = 13,
                BreedName = "Husky",
                ImgUrl = "/img/husky.png",
                Parent1BreedId = 13,
                Parent2BreedId = 13,
            };

            Breed JackRuss = new Breed()
            {
                Id = 14,
                BreedName = "Jack Russel",
                ImgUrl = "/img/Jack_Russel.png",
                Parent1BreedId = 14,
                Parent2BreedId = 14,
            };

            Breed KCSpaniel = new Breed()
            {
                Id = 15,
                BreedName = "King Charles Spaniel",
                ImgUrl = "/img/KC_Spaniel.png",
                Parent1BreedId = 15,
                Parent2BreedId = 15,
            };

            Breed Labrador = new Breed()
            {
                Id = 16,
                BreedName = "Labrador",
                ImgUrl = "/img/Labrador.png",
                Parent1BreedId = 16,
                Parent2BreedId = 16,
            };

            Breed Maltese = new Breed()
            {
                Id = 17,
                BreedName = "Maltese Poodle",
                ImgUrl = "/img/Maltese_Poodle.png",
                Parent1BreedId = 17,
                Parent2BreedId = 17,
            };

            Breed Pekingese = new Breed()
            {
                Id = 18,
                BreedName = "Pekingese",
                ImgUrl = "/img/pekingese.png",
                Parent1BreedId = 18,
                Parent2BreedId = 18,
            };

            Breed Pointer = new Breed()
            {
                Id = 19,
                BreedName = "Pointer",
                ImgUrl = "/img/pointer.png",
                Parent1BreedId = 19,
                Parent2BreedId = 19,
            };

            Breed Pom = new Breed()
            {
                Id = 20,
                BreedName = "Pomeranian",
                ImgUrl = "/img/Pomeranian.png",
                Parent1BreedId = 20,
                Parent2BreedId = 20,
            };

            Breed Poodle = new Breed()
            {
                Id = 21,
                BreedName = "Poodle",
                ImgUrl = "/img/Poodle.png",
                Parent1BreedId = 21,
                Parent2BreedId = 21,
            };

            Breed Pug = new Breed()
            {
                Id = 22,
                BreedName = "Pug",
                ImgUrl = "/img/pug.png",
                Parent1BreedId = 22,
                Parent2BreedId = 22,
            };

            Breed Schnauzer = new Breed()
            {
                Id = 23,
                BreedName = "Schnauzer",
                ImgUrl = "/img/Schnauzer.png",
                Parent1BreedId = 23,
                Parent2BreedId = 23,
            };

            Breed ShihTzu = new Breed()
            {
                Id = 24,
                BreedName = "Shih Tzu",
                ImgUrl = "/img/Shih_tzu.png",
                Parent1BreedId = 24,
                Parent2BreedId = 24,
            };

            Breed WHTerrier = new Breed()
            {
                Id = 25,
                BreedName = "West Highlands Terrier",
                ImgUrl = "/img/WH_terrier.png",
                Parent1BreedId = 25,
                Parent2BreedId = 25,
            };

            Breed Yorkie = new Breed()
            {
                Id = 26,
                BreedName = "Yorkshire Terrier",
                ImgUrl = "/img/Yorkie.png",
                Parent1BreedId = 26,
                Parent2BreedId = 26,
            };

            Breed[] PureBreeds = { AusCattle, AusShep, Beagle, Bichon, Chihuahua, CockerSpaniel, Collie, Corgi, Daschund, EngSpringerSpaniel, GermanShep, Goldie, Greyhound, Husky, JackRuss, KCSpaniel, Labrador, Maltese, Pekingese, Pointer, Pom, Poodle, Pug, Schnauzer, ShihTzu, WHTerrier, Yorkie };
            return (PureBreeds);
        }

        public InventoryContext (DbContextOptions<InventoryContext> options)
            : base(options)
        {

        }

        public DbSet<Inventory.Models.Dog>? Dog { get; set; }

    }


}
