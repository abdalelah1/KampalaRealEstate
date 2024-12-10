using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }  // Foreign Key to User

        public User User { get; set; }  // Navigation Property to User

        [Required, MaxLength(50)]
        public string Plan { get; set; }  // Subscription Plan (Standard, Premium, VIP)

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }  // Subscription Start Date

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }  // Subscription End Date

        public bool IsActive { get; set; } = true;  // Active Status
    }
}
