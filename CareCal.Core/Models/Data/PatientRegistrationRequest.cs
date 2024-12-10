using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCal.Core.Models.Data
{
    public class PatientRegistrationRequest
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        public int UserId { get; set; } // Reference to the User who is registering as a patient

        [Required]
        public string BloodType { get; set; }

        public string MedicalHistory { get; set; }

        public string Allergies { get; set; }

        public string InsuranceProvider { get; set; }

        public string InsurancePolicyNumber { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string EmergencyContact { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation property to User
        public User User { get; set; }
    }
}
