using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Models
{
    public class AppointmentRequest
    {
        [Key]
        public int RequestId { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } // Navigation property

        [Required]
        public string Symptoms { get; set; }

        [Required]
        public DateTime RequestedDate { get; set; }

        [Required]
        public string Status { get; set; } // "Pending", "Accepted", "Rejected"

        public DateTime? AppointmentDate { get; set; } // Nullable, set by the doctor

        // Additional fields
        public string AppointmentType { get; set; } // Example: "Consultation", "Check-up"
        public string Priority { get; set; } // Example: "Low", "Medium", "High"
        public string ReasonForAppointment { get; set; }
        public bool IsFollowUp { get; set; }
        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string Location { get; set; } // Where the appointment takes place
        public bool IsConfirmed { get; set; } // Patient's confirmation status
        public string PaymentStatus { get; set; } // Example: "Paid", "Pending"
        // Navigation property for Payment
        public Payment Payment { get; set; }
        public string AppointmentMode { get; set; } // Example: "In-Person", "Telemedicine"

        public string DoctorFeedback { get; set; } // Feedback from doctor after appointment
        public string PatientFeedback { get; set; } // Feedback from patient after appointment

        public TimeSpan Duration { get; set; } // Expected duration of the appointment
    }
}
