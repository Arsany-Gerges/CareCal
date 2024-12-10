using CareCal.Core.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareCal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public ActionResult RegisterUser()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult Login()
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateProfile()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetUserDetails()
        {
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteAccount()
        {
            return Ok();
        }
    }
}
