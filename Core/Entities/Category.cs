using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [Required, MaxLength(100)]
        public string Name { get; set; }  // Category Name

        [MaxLength(500)]
        public string Description { get; set; }  // Category Description
        public ICollection<Property> Properties { get; set; }  // Navigation Property to Properties


    }
}
