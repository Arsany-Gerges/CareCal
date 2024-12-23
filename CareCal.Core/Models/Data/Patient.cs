﻿using System.ComponentModel.DataAnnotations;

namespace CareCal.Core.Models.Data
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; } // Primary key

        [Required]
        public int UserId { get; set; } // Foreign key
        public User User { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Age must be a positive number.")]
        public int Age { get; set; }
        // Medical and health-related fields
        public string MedicalHistory { get; set; }
        public string Allergies { get; set; }
        public string EmergencyContact { get; set; }
        public string InsuranceProvider { get; set; }
        public string InsurancePolicyNumber { get; set; }
        [Required]
        public string BloodType { get; set; }
        public string PrimaryCarePhysician { get; set; }
        public string CurrentMedications { get; set; }
        public string PreferredContactMethod { get; set; }
        public string ReferralSource { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public bool IsActive { get; set; }
        // Navigation property
        public List<AppointmentRequest> AppointmentRequests { get; set; } = new List<AppointmentRequest>();
        public List<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public List<UserNotification> Notifications { get; set; } = new List<UserNotification>();
    }
}