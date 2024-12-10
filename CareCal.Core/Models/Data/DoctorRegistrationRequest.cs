using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCal.Core.Models.Data
{
    public class DoctorRegistrationRequest
    {
        [Key]
        public int RequestId { get; set; } // Unique identifier for the request

        [Required]
        public int UserId { get; set; } // Foreign key to the User

        [Required]
        public string LicenseNumber { get; set; } // The doctor's license number

        [Required]
        public string Specialization { get; set; } // Specialization of the doctor

        public string Qualification { get; set; } // Optional qualification document

        public string HospitalOrClinic { get; set; } // Information about the workplace

        public string ClinicAddress { get; set; } // Clinic or hospital address

        public bool IsVerified { get; set; } // Flag indicating if the doctor has been verified

        public string VerificationStatus { get; set; } // "Pending", "Approved", "Rejected"

        public DateTime? VerificationDate { get; set; } // Date when the doctor was verified or rejected

        public string Notes { get; set; } // Admin or system notes for review

        [Required]
        public DateTime CreatedAt { get; set; } // When the registration request was created

        // Navigation property to the User
        public User User { get; set; }
    }
}
