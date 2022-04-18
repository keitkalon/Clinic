using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        public ProfilesController()
        {

        }
        public ActionResult TestInBoundConnection()
        {
            Console.WriteLine("--> Inbound Post # Command Service");
            return Ok("Inbound test from Profiles Controllers");
        }
    }
}
