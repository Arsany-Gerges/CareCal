using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Core.Models.Data
{
    public class UserNotification
    {
        [Key]
        public int NotificationId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } // Navigation property

        public string NotificationType { get; set; }
        public string Message { get; set; }
        public string Status { get; set; } // "Read" or "Unread"
        public DateTime NotificationDate { get; set; }
    }
}
