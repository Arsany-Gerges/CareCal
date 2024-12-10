using CareCal.Core.Models.Data;
using CareCal.Core.Models.Repository;
using CareCal.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCal.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CareCalDbContext context;
        public UnitOfWork(CareCalDbContext context) { 
            this.context=context;

            Users = new Repository<User>(context);
            Patients = new Repository<Patient>(context);
            Doctors = new Repository<Doctor>(context);
            AppointmentRequests = new Repository<AppointmentRequest>(context);

        }
        public IRepository<User> Users { get; private set; }
        public IRepository<Patient> Patients { get; private set; }
        public IRepository<Doctor> Doctors { get; private set; }
        public IRepository<AppointmentRequest> AppointmentRequests { get; private set; }



        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
