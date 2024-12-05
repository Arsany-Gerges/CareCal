using Microsoft.EntityFrameworkCore;

namespace CareCal.Models
{
    public class CareCalDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AppointmentRequest> AppointmentRequests { get; set; }
        public DbSet<AppointmentReminder> AppointmentReminders { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }

        public CareCalDbContext(DbContextOptions<CareCalDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>().HasNoKey();

            //modelBuilder.Entity<Doctor>()
            //    .HasBaseType<User>();  // Mark Doctor as inheriting from User

            //modelBuilder.Entity<Patient>()
            //    .HasBaseType<User>();  // Mark Patient as inheriting from User

            //modelBuilder.Entity<Doctor>()
            //    .HasMany(d => d.AppointmentRequests)
            //    .WithOne(ar => ar.Doctor)
            //    .HasForeignKey(ar => ar.DoctorId);

            //modelBuilder.Entity<Patient>()
            //    .HasMany(p => p.AppointmentRequests)
            //    .WithOne(ar => ar.Patient)
            //    .HasForeignKey(ar => ar.PatientId);
        }
    }
}
