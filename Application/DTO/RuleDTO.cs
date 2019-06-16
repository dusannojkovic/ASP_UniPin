using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class RuleDTO
    {
        public int Id { get; set; }
        [Range(4, 15, ErrorMessage = "Naziv ne sme preci 15 karaktera.")]
        [Required]
        public string Naziv { get; set; }
    }
}
