using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Core.Models.Data
{
    public class AppointmentReminder
    {
        [Key]
        public int ReminderId { get; set; }

        public int AppointmentId { get; set; }
        public AppointmentRequest Appointment { get; set; } // Navigation property

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public DateTime ReminderDate { get; set; }
        public string ReminderType { get; set; } // "SMS", "Email"
        public string Status { get; set; } // "Sent", "Pending"
    }
}
