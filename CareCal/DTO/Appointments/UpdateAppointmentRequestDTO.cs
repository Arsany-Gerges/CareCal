namespace CareCal.DTO.Appointments
{
    public class UpdateAppointmentRequestDTO
    {
        public int RequestId { get; set; } // Required to identify the appointment
        public string Symptoms { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string Status { get; set; } // "Pending", "Accepted", "Rejected"
        public string Priority { get; set; }
        public string Notes { get; set; }
        public bool IsConfirmed { get; set; }
        public string PaymentStatus { get; set; } // "Paid", "Pending"
        public string AppointmentMode { get; set; }
        public string DoctorFeedback { get; set; }
        public string PatientFeedback { get; set; }
        public string Duration { get; set; }
    }
}
