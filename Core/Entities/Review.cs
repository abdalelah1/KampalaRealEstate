using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }  // Foreign Key to Property

        public Property Property { get; set; }  // Navigation Property to Property

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }  // Foreign Key to User

        public User User { get; set; }  // Navigation Property to User

        [Required, MaxLength(1000)]
        public string Comment { get; set; }  // Review Comment

        [Range(1, 5)]
        public int Rating { get; set; }  // Review Rating (1-5)

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Review Date
    }
}
