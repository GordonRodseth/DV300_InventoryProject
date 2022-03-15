using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Inventory.Models;

namespace Inventory.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Breed AusCattle = new Breed()
            {
                Id = 1,
                BreedName = "Australian Cattle Dog",
                ImgUrl = "~lib/Aus_Cattle_Dog",
                Parent1BreedId = 1,
                Parent2BreedId = 1,
            };

            Breed AusShep = new Breed()
            {
                Id = 2,
                BreedName = "Australian Shepherd",
                ImgUrl = "~lib/Aussie_shepherd",
                Parent1BreedId = 2,
                Parent2BreedId = 2,
            };

            Breed Beagle = new Breed()
            {
                Id = 3,
                BreedName = "Beagle",
                ImgUrl = "~lib/Beagle",
                Parent1BreedId = 3,
                Parent2BreedId = 3,
            };

            Breed Bichon = new Breed()
            {
                Id = 4,
                BreedName = "Bichon Frise",
                ImgUrl = "~lib/bichon_frise",
                Parent1BreedId = 4,
                Parent2BreedId = 4,
            };

            Breed Chihuahua = new Breed()
            {
                Id = 5,
                BreedName = "Chihuahua",
                ImgUrl = "~lib/Chihuahua",
                Parent1BreedId = 5,
                Parent2BreedId = 5,
            };

            Breed CockerSpaniel = new Breed()
            {
                Id = 6,
                BreedName = "Cocker Spaniel",
                ImgUrl = "~lib/Cocker_Spaniel",
                Parent1BreedId = 6,
                Parent2BreedId = 6,
            };

            Breed Collie = new Breed()
            {
                Id = 7,
                BreedName = "Border Collie",
                ImgUrl = "~lib/Collie",
                Parent1BreedId = 7,
                Parent2BreedId = 7,
            };

            Breed Corgi = new Breed()
            {
                Id = 8,
                BreedName = "Corgi",
                ImgUrl = "~lib/Corgi",
                Parent1BreedId = 8,
                Parent2BreedId = 8,
            };

            Breed Daschund = new Breed()
            {
                Id = 9,
                BreedName = "Daschund",
                ImgUrl = "~lib/Daschund",
                Parent1BreedId = 9,
                Parent2BreedId = 9,
            };

            Breed EngSpringerSpaniel = new Breed()
            {
                Id = 10,
                BreedName = "English Springer Spaniel",
                ImgUrl = "~lib/English_Springer_Spaniel",
                Parent1BreedId = 10,
                Parent2BreedId = 10,
            };

            Breed GermanShep = new Breed()
            {
                Id = 11,
                BreedName = "German Shepherd",
                ImgUrl = "~lib/german_shepherd",
                Parent1BreedId = 11,
                Parent2BreedId = 11,
            };

            Breed Goldie = new Breed()
            {
                Id = 12,
                BreedName = "Golden Retriever",
                ImgUrl = "~lib/Golden_Retriever",
                Parent1BreedId = 12,
                Parent2BreedId = 12,
            };

            Breed Greyhound = new Breed()
            {
                Id = 13,
                BreedName = "Greyhound",
                ImgUrl = "~lib/Greyhound",
                Parent1BreedId = 13,
                Parent2BreedId = 13,
            };

            Breed Husky = new Breed()
            {
                Id = 14,
                BreedName = "Husky",
                ImgUrl = "~lib/husky",
                Parent1BreedId = 14,
                Parent2BreedId = 14,
            };

            Breed JackRuss = new Breed()
            {
                Id = 15,
                BreedName = "Jack Russel",
                ImgUrl = "~lib/Jack_Russel",
                Parent1BreedId = 15,
                Parent2BreedId = 15,
            };

            Breed KCSpaniel = new Breed()
            {
                Id = 16,
                BreedName = "King Charles Spaniel",
                ImgUrl = "~lib/KC_Spaniel",
                Parent1BreedId = 16,
                Parent2BreedId = 16,
            };

            Breed Labrador = new Breed()
            {
                Id = 17,
                BreedName = "Labrador",
                ImgUrl = "~lib/Labrador",
                Parent1BreedId = 17,
                Parent2BreedId = 17,
            };

            Breed Maltese = new Breed()
            {
                Id = 18,
                BreedName = "Maltese Poodle",
                ImgUrl = "~lib/Maltese_Poodle",
                Parent1BreedId = 18,
                Parent2BreedId = 18,
            };

            Breed Pekingese = new Breed()
            {
                Id = 19,
                BreedName = "Pekingese",
                ImgUrl = "~lib/pekingese",
                Parent1BreedId = 19,
                Parent2BreedId = 19,
            };

            Breed Pointer = new Breed()
            {
                Id = 20,
                BreedName = "Pointer",
                ImgUrl = "~lib/pointer",
                Parent1BreedId = 20,
                Parent2BreedId = 20,
            };

            Breed Pom = new Breed()
            {
                Id = 21,
                BreedName = "Pomeranian",
                ImgUrl = "~lib/Pomeranian",
                Parent1BreedId = 21,
                Parent2BreedId = 21,
            };

            Breed Poodle = new Breed()
            {
                Id = 22,
                BreedName = "Poodle",
                ImgUrl = "~lib/Poodle",
                Parent1BreedId = 22,
                Parent2BreedId = 22,
            };

            Breed Pug = new Breed()
            {
                Id = 23,
                BreedName = "Pug",
                ImgUrl = "~lib/pug",
                Parent1BreedId = 23,
                Parent2BreedId = 23,
            };

            Breed Schnauzer = new Breed()
            {
                Id = 24,
                BreedName = "Schnauzer",
                ImgUrl = "~lib/Schnauzer",
                Parent1BreedId = 24,
                Parent2BreedId = 24,
            };

            Breed ShihTzu = new Breed()
            {
                Id = 25,
                BreedName = "Shih Tzu",
                ImgUrl = "~lib/Shih_tzu",
                Parent1BreedId = 25,
                Parent2BreedId = 25,
            };

            Breed WHTerrier = new Breed()
            {
                Id = 26,
                BreedName = "West Highlands Terrier",
                ImgUrl = "~lib/WH_terrier",
                Parent1BreedId = 26,
                Parent2BreedId = 26,
            };

            Breed Yorkie = new Breed()
            {
                Id = 27,
                BreedName = "Yorkshire Terrier",
                ImgUrl = "~lib/Yorkie",
                Parent1BreedId = 27,
                Parent2BreedId = 27,
            };

            Breed[] PureBreeds = { AusCattle,AusShep,Beagle,Bichon,Chihuahua,CockerSpaniel,Collie,Corgi,Daschund,EngSpringerSpaniel,GermanShep,Goldie,Greyhound,Husky,JackRuss,KCSpaniel,Labrador,Maltese,Pekingese,Pointer,Pom,Poodle,Pug,Schnauzer,ShihTzu,WHTerrier,Yorkie };
            ViewData["PureBreeds"] = PureBreeds;
        }
    }
}