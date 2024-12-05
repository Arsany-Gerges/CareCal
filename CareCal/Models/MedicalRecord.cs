using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareCal.Models
{
    public class MedicalRecord
    {
        [Key]
        public int RecordId { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } // Navigation property

        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
