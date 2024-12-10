using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public MedicalRecordController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public ActionResult AddMedicalRecord()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateMedicalRecord()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult ViewMedicalRecords()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetMedicalRecordById()
        {
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteMedicalRecord()
        {
            return Ok();
        }
    }
}
