using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniPin.Api
{
    public class CreatePicture
    {

        public string Alt { get; set; }

        
        public IFormFile Image  { get; set; }
    }
}
