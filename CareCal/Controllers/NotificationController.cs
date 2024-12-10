using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public NotificationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public ActionResult SentNotification()
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult MarkAsRead()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult ListNotification()
        {
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteNotification()
        {
            return Ok();
        }
    }
}
