using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentReminderController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public AppointmentReminderController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public ActionResult CreateReminder()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateReminderStatus()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult ListReminders()
        {
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteReminder()
        {
            return Ok();
        }
    }
}
