using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.Commands;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UniPin.Api.Helpers;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IloggedUserCommand _userLog;
        private readonly Encryption _enc;

        public AuthController(IloggedUserCommand userLog, Encryption enc)
        {
            _userLog = userLog;
            _enc = enc;
        }

        // POST: api/Auth
        [HttpPost]
        public IActionResult Post(/*[FromQuery] Logged user*/)
        {
            //try
            //{
            //    var userLogged = _userLog.Execute(user);
            //    var stringObject = JsonConvert.SerializeObject(userLogged);

            //    var encrypted = _enc.EncryptString(stringObject);
            //    return Ok(new {token = encrypted});
            //}
            //catch (EntityNotFoundException)
            //{

            //    throw;
            //}

            var user = new LoggedUser
            {
                FirstName = "Dusan",
                LastName = "Nojkovic",
                Id = 5,
                Username = "pera123",
                Role = "user",
                Password = "sifra1"
                
            };

            var stringObject = JsonConvert.SerializeObject(user);
            var encrypted = _enc.EncryptString(stringObject);
 
            return Ok(new {token = encrypted});
        }
        [HttpGet("decode")]
        public  IActionResult Decode(string value)
        {
            var decodedString = _enc.DecryptString(value);
            return null;
        } 

       
    }
}
