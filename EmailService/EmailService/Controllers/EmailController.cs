using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Email.Models;
using Email.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailModel request)
        {
            _emailService.SendEmail(request);
            return Ok();
        }
    }
}

