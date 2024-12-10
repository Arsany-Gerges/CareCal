using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PrescriptionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public ActionResult CreatePrescription()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdatePrescription()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult ViewPrescriptions()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetPrescriptionById()
        {
            return Ok();
        }
    }
}
