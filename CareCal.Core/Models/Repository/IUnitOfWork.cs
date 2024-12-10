using CareCal.Core.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareCal.Core.Models.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Patient> Patients { get; }
        IRepository<Doctor> Doctors { get; }
        IRepository<AppointmentRequest> AppointmentRequests { get; }
        IRepository<User> Users { get; }

        int Save();
    }
}
