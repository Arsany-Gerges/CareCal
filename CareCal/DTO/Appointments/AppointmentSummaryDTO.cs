namespace CareCal.DTO.Appointments
{
    public class AppointmentSummaryDTO
    {
        public int RequestId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
        public string AppointmentType { get; set; }
    }
}
