using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }  // Foreign Key to User

        public User User { get; set; }  // Navigation Property to User

        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }  // Foreign Key to Property

        public Property Property { get; set; }  // Navigation Property to Property

        [DataType(DataType.DateTime)]
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;  // Date when added to favorites
    }
}
