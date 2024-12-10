using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public DoctorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult GetDoctorDetails(int id)
        {
            var doctor = unitOfWork.Doctors.GetById(id);
            return Ok(doctor);
        }
        [HttpGet]
        public ActionResult GetAllDoctor()
        {
            var doctors = unitOfWork.Doctors.GetAll();
            return Ok(doctors);
        }
        [HttpPost]
        public ActionResult RegisterDoctor()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult ApproveDoctor()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateDoctorProfle()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult SearchDoctors()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetDoctorAppointments()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult ProvideFeedback()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult UploadDocumenta()
        {
            return Ok();
        }
    }
}
