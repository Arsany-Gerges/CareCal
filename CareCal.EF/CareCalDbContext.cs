using CareCal.Core.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace CareCal.EF
{
    public class CareCalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientRegistrationRequest> PatientRegistrationRequests { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorRegistrationRequest> DoctorRegistrationRequests { get; set; }
        public DbSet<AppointmentRequest> AppointmentRequests { get; set; }
        public DbSet<AppointmentReminder> AppointmentReminders { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }

        public CareCalDbContext(DbContextOptions<CareCalDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //// Foriegn keys of appointment
            //modelBuilder.Entity<AppointmentRequest>()
            //    .HasOne(a=>a.Patient)
            //    .WithMany()
            //    .HasForeignKey(a => a.PatientId)
            //    .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<AppointmentRequest>()
            //    .HasOne(a => a.Doctor)
            //    .WithMany()
            //    .HasForeignKey(a => a.DoctorId)
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
