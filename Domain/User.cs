using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class User : Bazna
    {
        public string Ime { get; set; }
        public string  Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka  { get; set; }

        public int RuleId { get; set; }
        public Rule Rule { get; set; }
     
    }
}
