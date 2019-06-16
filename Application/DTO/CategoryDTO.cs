using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [StringLength( 30, ErrorMessage = "Naziv ne sme preci 30 karaktera.")]
        [Required]
        public string Naziv { get; set; }
    }
}
