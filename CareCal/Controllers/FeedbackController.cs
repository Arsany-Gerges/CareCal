using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public FeedbackController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public ActionResult SubmitGeedbck()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetFeedbackForDoctor()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetFeedbackForPatient()
        {
            return Ok();
        }
    }
}
