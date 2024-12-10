using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [Required, MaxLength(50)]
        public string Name { get; set; }  // Role Name (e.g., Admin, Investor)

        [MaxLength(250)]
        public string Description { get; set; }  // Role Description

        public ICollection<User> Users { get; set; }  // Navigation Property to Users
    }
}
