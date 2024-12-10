using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kampala_Real_Estate.Core.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey(nameof(Sender))]
        public int SenderId { get; set; }  // Foreign Key to Sender

        public User Sender { get; set; }  // Navigation Property to Sender

        [ForeignKey(nameof(Receiver))]
        public int ReceiverId { get; set; }  // Foreign Key to Receiver

        public User Receiver { get; set; }  // Navigation Property to Receiver

        [Required, MaxLength(1000)]
        public string Content { get; set; }  // Message Content

        [DataType(DataType.DateTime)]
        public DateTime SentAt { get; set; } = DateTime.UtcNow;  // Sent Timestamp

        public bool IsRead { get; set; } = false;  // Read Status
    }
}
