namespace CareCal.DTO.Appointments
{
    public class CreateAppointmentRequestDTO
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Symptoms { get; set; }
        public DateTime RequestedDate { get; set; }
        public string AppointmentType { get; set; }
        public string Priority { get; set; }
        public string ReasonForAppointment { get; set; }
        public bool IsFollowUp { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }
        public string AppointmentMode { get; set; }
    }
}
