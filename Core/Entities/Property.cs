using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Property
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [Required, MaxLength(150)]
        public string Name { get; set; }  // Property Name

        [Required, MaxLength(50)]
        public string Type { get; set; }  // Property Type (House, Villa, Commercial)

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }  // Property Price

        [Required, MaxLength(200)]
        public string Location { get; set; }  // Property Location

        [MaxLength(1000)]
        public string Description { get; set; }  // Property Description

        [ForeignKey(nameof(User))]
        public int OwnerId { get; set; }  // Foreign Key to User (Owner)

        public User Owner { get; set; }  // Navigation Property to
                                         
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }  // Foreign Key to Category

        public Category Category { get; set; }  // Navigation Property to Category

        [DataType(DataType.DateTime)]
        public DateTime ListedAt { get; set; } = DateTime.UtcNow;  // Listing Date

        public bool IsAvailable { get; set; } = true;  // Availability Status
    }    
    
}
