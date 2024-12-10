using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Core.Models.Data
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } // Navigation property

        public int Rating { get; set; } // Rating out of 5
        public string Comments { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
