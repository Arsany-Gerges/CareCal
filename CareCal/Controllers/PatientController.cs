using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PatientController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public ActionResult RegisterPatient()
        {
            return Ok();
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPatientDetails()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdatePatientProfile()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult SerchDoctors()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult BookAppointment()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult ProvideFeedback()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult ViewMedicalHistory()
        {
            return Ok();
        }
    }
}
