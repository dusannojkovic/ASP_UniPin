using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Rule : Bazna
    {

        public string  Naziv { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
