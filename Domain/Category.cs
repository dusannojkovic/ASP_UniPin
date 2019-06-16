using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Category : Bazna
    {
       
        public string  Naziv { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
