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
        public IActionResult Post([FromQuery] Logged userdto)
        {
           
                var userLogged = _userLog.Execute(userdto);
                var stringObject = JsonConvert.SerializeObject(userLogged);

                var encrypted = _enc.EncryptString(stringObject);
            
            
      

         //probao sam autorizaciju ali mi izbacuje gresku prilikom decripcije, navodno token koji posaljem nije string64

       
 
            return Ok(new {token = encrypted});
        }
        [HttpGet("decode")]
        public  IActionResult Decode(string value)
        {
            var decodedString = _enc.DecryptString(value);
            return Ok(decodedString);
        } 

       
    }
}
