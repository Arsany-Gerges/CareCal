using CareCal.DTO.Appointments;
using CareCal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CareCal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class appointmentsController : ControllerBase
    {
        CareCalDbContext context;
        public appointmentsController(CareCalDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("{id:int}/Detailed")]
        public ActionResult GetAppointmentById(int id)
        {
            AppointmentRequest appointment = context.AppointmentRequests.Include(a => a.Patient).Include(a => a.Doctor).FirstOrDefault(a => a.RequestId == id);
            if (appointment == null)
            {
                return NotFound(new { message = "Appointment not found" });
            }
            AppointmentRequestDetailsDTO appointmentDto = new AppointmentRequestDetailsDTO
            {
                RequestId = appointment.RequestId,
                PatientId = appointment.PatientId,
                PatientName = appointment.Patient.Name, // Assuming Patient has a Name property
                DoctorId = appointment.DoctorId,
                DoctorName = appointment.Doctor.Name, // Assuming Doctor has a Name property
                Symptoms = appointment.Symptoms,
                RequestedDate = appointment.RequestedDate,
                Status = appointment.Status,
                AppointmentDate = appointment.AppointmentDate,
                AppointmentType = appointment.AppointmentType,
                Priority = appointment.Priority,
                Location = appointment.Location,
                IsConfirmed = appointment.IsConfirmed,
                PaymentStatus = appointment.PaymentStatus,
                AppointmentMode = appointment.AppointmentMode,
                Notes = appointment.Notes,
                DoctorFeedback = appointment.DoctorFeedback,
                PatientFeedback = appointment.PatientFeedback,
                Duration = appointment.Duration
            };
            
            return Ok(appointmentDto);
        }

        [HttpGet]
        [Route("{id:int}/Summary")]
        public ActionResult GetAppointmentSummaryById(int id)
        {
            // Fetch the appointment along with related Patient and Doctor data
            var appointment = context.AppointmentRequests
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .FirstOrDefault(a => a.RequestId == id);

            if (appointment == null)
            {
                return NotFound(new { message = "Appointment not found" });
            }

            // Map data from the appointment to the summary DTO
            var appointmentSummaryDto = new AppointmentSummaryDTO
            {
                RequestId = appointment.RequestId,
                PatientName = appointment.Patient?.Name, // Assuming Patient has a Name property
                DoctorName = appointment.Doctor?.Name,   // Assuming Doctor has a Name property
                RequestedDate = appointment.RequestedDate,
                Status = appointment.Status,
                AppointmentType = appointment.AppointmentType
            };

            return Ok(appointmentSummaryDto);
        }

        //GET: api/AppointmentRequests/Doctor/{doctorId}
        [HttpGet("Doctor/{doctorId}")]
        public async Task<ActionResult<IEnumerable<DoctorRequestDTO>>> GetRequestsForDoctor(int doctorId)
        {
            var requests = await context.AppointmentRequests
                .Include(ar => ar.Patient)
                .Where(ar => ar.DoctorId == doctorId)
                .Select(ar => new DoctorRequestDTO
                {
                    RequestId = ar.RequestId,
                    PatientName = ar.Patient.Name,
                    Symptoms = ar.Symptoms,
                    RequestedDate = ar.RequestedDate,
                    Status = ar.Status,
                    AppointmentType = ar.AppointmentType,
                    Priority = ar.Priority,
                    Notes = ar.Notes
                })
                .ToListAsync();

            return Ok(requests);
        }
        [HttpGet("Patient/{patientId}")]
        public async Task<ActionResult<IEnumerable<PatientRequestDTO>>> GetRequestsForPatient(int patientId)
        {
            var requests = await context.AppointmentRequests
                .Include(ar => ar.Doctor)
                .Where(ar => ar.PatientId == patientId)
                .Select(ar => new PatientRequestDTO
                {
                    RequestId = ar.RequestId,
                    DoctorName = ar.Doctor.Name,
                    Status = ar.Status,
                    AppointmentDate = ar.AppointmentDate,
                    AppointmentType = ar.AppointmentType,
                    Notes = ar.Notes
                })
                .ToListAsync();

            return Ok(requests);
        }
        [HttpPost]
        public ActionResult CreateAppointmentRequest(CreateAppointmentRequestDTO dto)
        {
            var appointmentRequest = new AppointmentRequest
            {
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                Symptoms = dto.Symptoms,
                RequestedDate = dto.RequestedDate,
                AppointmentType = dto.AppointmentType,
                Priority = dto.Priority,
                ReasonForAppointment = dto.ReasonForAppointment,
                IsFollowUp = dto.IsFollowUp,
                Location = dto.Location,
                Notes = dto.Notes,
                AppointmentMode = dto.AppointmentMode,
                Status = "Pending", // Default status for a new appointment
                CreatedAt = DateTime.Now // Automatically set creation time
            };
            context.AppointmentRequests.Add(appointmentRequest);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetAppointmentById), new { id = appointmentRequest.RequestId }, new
            {
                appointmentRequest.RequestId,
                message = "Appointment request created successfully."
            });
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult UpdateAppointment(int id, UpdateAppointmentRequestDTO dto)
        {
            var existingAppointment = context.AppointmentRequests.FirstOrDefault(a => a.RequestId == id);
            if (existingAppointment == null)
            {
                return NotFound(new { message = "Appointment not found" });
            }
            // Update the properties of the existing appointment using the DTO
            if (!string.IsNullOrEmpty(dto.Symptoms))
            {
                existingAppointment.Symptoms = dto.Symptoms;
            }

            if (dto.AppointmentDate.HasValue)
            {
                existingAppointment.AppointmentDate = dto.AppointmentDate;
            }

            if (!string.IsNullOrEmpty(dto.Status))
            {
                existingAppointment.Status = dto.Status;
            }

            if (!string.IsNullOrEmpty(dto.Priority))
            {
                existingAppointment.Priority = dto.Priority;
            }

            if (!string.IsNullOrEmpty(dto.Notes))
            {
                existingAppointment.Notes = dto.Notes;
            }

            if (dto.IsConfirmed)
            {
                existingAppointment.IsConfirmed = dto.IsConfirmed;
            }

            if (!string.IsNullOrEmpty(dto.PaymentStatus))
            {
                existingAppointment.PaymentStatus = dto.PaymentStatus;
            }

            if (!string.IsNullOrEmpty(dto.AppointmentMode))
            {
                existingAppointment.AppointmentMode = dto.AppointmentMode;
            }

            if (!string.IsNullOrEmpty(dto.DoctorFeedback))
            {
                existingAppointment.DoctorFeedback = dto.DoctorFeedback;
            }

            if (!string.IsNullOrEmpty(dto.PatientFeedback))
            {
                existingAppointment.PatientFeedback = dto.PatientFeedback;
            }

            if (!string.IsNullOrEmpty(dto.Duration))
            {
                existingAppointment.Duration = dto.Duration;
            }

            context.Entry(existingAppointment).State = EntityState.Modified;
            context.SaveChangesAsync();
            return Ok(new { message = "Appointment Updated successfully" });
        }

        [HttpPut]
        [Route("{id:int}/confirm")]
        public ActionResult ConfirmAppointment(int id)
        {
            AppointmentRequest appointment = context.AppointmentRequests.Include(a => a.Patient).Include(a => a.Doctor).FirstOrDefault(a => a.RequestId == id);
            if (appointment == null)
            {
                return NotFound();
            }
            appointment.Status = "Confirmed";
            context.Entry(appointment).State = EntityState.Modified;
            context.SaveChangesAsync();
            return Ok(new { message = "Appointment confirmed successfully" });
        }
        [HttpPut]
        [Route("{id:int}/reject")]
        public ActionResult RejectAppointment(int id)
        {
            AppointmentRequest appointment = context.AppointmentRequests.Include(a => a.Patient).Include(a => a.Doctor).FirstOrDefault(a => a.RequestId == id);
            if (appointment == null)
            {
                return NotFound();
            }
            appointment.Status = "Rejected";
            context.Entry(appointment).State = EntityState.Modified;
            context.SaveChangesAsync();
            return Ok(new { message = "Appointment Rejected successfully" });
        }

    }
}
