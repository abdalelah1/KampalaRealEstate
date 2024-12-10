using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Kampala_Real_Estate.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [Required, MaxLength(100)]
        public string Name { get; set; }  // User's Full Name

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; }  // User's Email Address

        [Required]
        public string PasswordHash { get; set; }  // Encrypted Password

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }  // Foreign Key to Role

        public Role Role { get; set; }  // Navigation Property to Role
        public ICollection<Favorite> Favorites { get; set; }  // Navigation Property to Favorites

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Account Creation Date

        public bool IsActive { get; set; } = true;  // Active Status
    }    
    
}
