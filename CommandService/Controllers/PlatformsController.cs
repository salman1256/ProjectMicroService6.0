using Microsoft.AspNetCore.Mvc;

namespace CommandService.Cotrollers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController:ControllerBase
    {
        [HttpPost]
        public ActionResult TestInBoundConnection()
        {
            System.Console.WriteLine("In bound POST Command Service Started!!!");
            return Ok("Inbound test of Command Service from Platform Controller");
        }

    }
}