using CareCal.DTO.Appointments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CareCal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class appointmentsController : ControllerBase
    {

        [HttpGet]
        [Route("{id:int}/Detailed")]
        public ActionResult GetAppointmentById(int id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id:int}/Summary")]
        public ActionResult GetAppointmentSummaryById(int id)
        {
            return Ok();
        }

        //GET: api/AppointmentRequests/Doctor/{doctorId}
        [HttpGet]
        public ActionResult ListAppointments(CreateAppointmentRequestDTO dto)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult CreateAppointmentRequest(CreateAppointmentRequestDTO dto)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult UpdateAppointment(int id, UpdateAppointmentRequestDTO dto)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}/confirm")]
        public ActionResult ConfirmAppointment(int id)
        {
            return Ok();
        }
        [HttpPut]
        [Route("{id:int}/reject")]
        public ActionResult RejectAppointment(int id)
        {
            return Ok();
        }

    }
}
