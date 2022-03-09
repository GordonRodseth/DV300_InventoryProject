using System.ComponentModel.DataAnnotations;
namespace Inventory.Models
{
    public class Dog
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public int BreedID { get; set; }
        public int MotherID { get; set; }
        public int FatherID { get; set; }
        public int KennelID { get; set; }
        public string Pedigree { get; set; } = string.Empty;
    }
}
