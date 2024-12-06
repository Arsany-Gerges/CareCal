namespace CareCal.DTO.Appointments
{
    public class PatientRequestDTO
    {
        public int RequestId { get; set; }
        public string DoctorName { get; set; }
        public string Status { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
        public string Notes { get; set; }
    }
}
