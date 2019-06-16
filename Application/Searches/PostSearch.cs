using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Searches
{
    public class PostSearch
    {
        public int? Id { get; set; }
        public string PostBy { get; set; }
        public int? PictureId { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int PerPage { get; set; } = 2;
        public int PageNumber { get; set; } = 1;
    }
}
