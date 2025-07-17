using Dependancy_Injection.DTO_s;
using Dependancy_Injection.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependancy_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotification _inotification;

        public NotificationController(INotification inotification)
        {
            this._inotification= inotification;
        }
        [HttpPost]
        public IActionResult SendNotification(NotificationRequest request)
        {
            var a = _inotification.send(request.to, request.message);
            return Ok(a);
        }
        [HttpGet]
        public IActionResult TestApi()
        {
            return Ok("success");
        }
        

    }
}
