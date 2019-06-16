using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }
        [Range(4, 100, ErrorMessage = "Tekst ne sme preci 100 karaktera.")]
        [Required]
        public string Tekst { get; set; }

        public string PostByUser { get; set; }
        public int PostId { get; set; }

        public int UserId { get; set; }
    }
}
