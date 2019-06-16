using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        [MinLength(4, ErrorMessage = "Naslov ne sme biti manji od 4 karaktera.")]
        [Required]
        public string Naslov { get; set; }
        [MinLength(5, ErrorMessage = "Opis ne sme biti manji od 5 karaktera.")]
        [Required]
        public string Opis { get; set; }
        public int PictureId { get; set; }
        public string PostBy { get; set; }
        public int CategoryId { get; set; }
        public bool? IsDeleted { get; set; }

        public string CategoryName { get; set; }
        public string Picture { get; set; }
        public int UserId { get; set; }

        public ICollection<CommentDTO> Comments { get; set; }
    }
}
