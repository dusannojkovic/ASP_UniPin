using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Post : Bazna
    {
    
        public string Naslov { get; set; }
        public string  Opis { get; set; }

        public bool? IsDeleted { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public int UserId { get; set; }
        public int PictureId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Picture Picture { get; set; }

        public User User { get; set; }

    }
}
