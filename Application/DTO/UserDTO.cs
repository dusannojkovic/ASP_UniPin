using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        [Range(3,20, ErrorMessage = "Ime ne sme preci 20 karaktera.")]
        public string Ime { get; set; }
        [Required]
        [Range(4, 30, ErrorMessage = "Prezime ne sme preci 30 karaktera.")]
        public string Prezime { get; set; }
        [Required,Range(4,16, ErrorMessage = "Korisnicko ime je obavezno i ne sme preci 16 karaktera")]
        public string KorisnickoIme { get; set; }
        [Required, RegularExpression("^([a-zA-Z0-9]{4,15})?",ErrorMessage = "Lozinka nije u dobrom formatu!")]
        public string Lozinka { get; set; }

        public int RuleId { get; set; }
    
    }
}
