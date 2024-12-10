using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public AdminController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult ReviewDoctorRegistrations()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult ApproveDoctorRegistrations()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult RejectDoctorRegistrations()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult ViewAllUsers()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult ManageAppointments()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult AuditLogs()
        {
            return Ok();
        }

    }
}
