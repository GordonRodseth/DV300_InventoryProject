namespace Inventory.Models
{
    public class Breed
    {
        public int Id { get; set; }

        public string BreedName { get; set; }=string.Empty;

        public string ImgUrl { get; set; }=string.Empty;

        public int Parent1BreedId { get; set; }
        public int Parent2BreedId { get; set; }
    }



}

