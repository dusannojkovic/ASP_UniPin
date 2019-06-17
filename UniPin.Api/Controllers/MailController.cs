using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private IEmailSender sender;

        public MailController(IEmailSender sender)
        {
            this.sender = sender;
        }

        // GET: api/Mail
        [HttpGet]
        public void Get(string email)
        {
            sender.Subject = "Uspesno logovanje";
            sender.ToEmail = email;
            sender.Body = "Blablablabla";
            sender.Send();
           
        }


        
    }
}
