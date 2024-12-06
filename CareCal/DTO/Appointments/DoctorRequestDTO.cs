namespace CareCal.DTO.Appointments
{
    public class DoctorRequestDTO
    {
        public int RequestId { get; set; }
        public string PatientName { get; set; }
        public string Symptoms { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
        public string AppointmentType { get; set; }
        public string Priority { get; set; }
        public string Notes { get; set; }
    }
}
