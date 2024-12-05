using System.ComponentModel.DataAnnotations;

namespace CareCal.Models
{
    public class Doctor : User
    {

        [Required]
        public string Specialization { get; set; }

        public string Qualification { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Years of Experience must be a positive number.")]
        public int YearsOfExperience { get; set; }

        [Required]
        public string HospitalOrClinic { get; set; }

        [Required]
        public string ClinicAddress { get; set; }

        [Required]
        public string WorkHours { get; set; } // Example: "9 AM - 5 PM"

        [Range(0, double.MaxValue, ErrorMessage = "Consultation Fee must be a positive number.")]
        public decimal ConsultationFee { get; set; }

        [Required]
        public string LicenseNumber { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public double Rating { get; set; } // Example rating out of 5

        [Range(0, int.MaxValue, ErrorMessage = "Review count must be a positive number.")]
        public int ReviewCount { get; set; }

        public string EmergencyContact { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        // Navigation property
        public List<AppointmentRequest> AppointmentRequests { get; set; } = new List<AppointmentRequest>();
        public List<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public List<UserNotification> Notifications { get; set; } = new List<UserNotification>();
    }
}
