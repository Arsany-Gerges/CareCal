using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Core.Models.Data
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } // Navigation property

        public string Medications { get; set; }
        public string Dosage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
