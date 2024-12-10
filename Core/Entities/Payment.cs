using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }  // Foreign Key to User

        public User User { get; set; }  // Navigation Property to User

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }  // Payment Amount

        [Required, MaxLength(50)]
        public string Type { get; set; }  // Payment Type (Subscription, Down Payment)

        [DataType(DataType.DateTime)]
        public DateTime PaidAt { get; set; } = DateTime.UtcNow;  // Payment Timestamp

        [MaxLength(20)]
        public string Status { get; set; } = "Pending";  // Payment Status (Pending, Completed)
    }
}
