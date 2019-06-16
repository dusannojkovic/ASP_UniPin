using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class PictureDTO
    {
        public int id { get; set; }
        [Range(4, 20, ErrorMessage = "Alt ne sme preci 20 karaktera.")]
        [Required]
        public string  Alt { get; set; }

        public string Putanja { get; set; }
    }
}
