using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int AppointmentRequestId { get; set; }
        public AppointmentRequest AppointmentRequest { get; set; } // Navigation property

        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } // Example: "Credit Card", "Cash"
        public string PaymentStatus { get; set; } // Example: "Paid", "Pending"
    }
}
