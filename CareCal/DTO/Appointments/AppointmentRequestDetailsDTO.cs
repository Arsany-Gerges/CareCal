namespace CareCal.DTO.Appointments
{
    public class AppointmentRequestDetailsDTO
    {
        public int RequestId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } // Assuming Patient entity has a Name property
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } // Assuming Doctor entity has a Name property
        public string Symptoms { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
        public string Priority { get; set; }
        public string Location { get; set; }
        public bool IsConfirmed { get; set; }
        public string PaymentStatus { get; set; }
        public string AppointmentMode { get; set; }
        public string Notes { get; set; }
        public string DoctorFeedback { get; set; }
        public string PatientFeedback { get; set; }
        public string Duration { get; set; }
    }
}
