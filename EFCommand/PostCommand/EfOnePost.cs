using Application.Commands.Post;
using Application.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfOnePost : EfBaseCommand, IGetOnePostCommand
    {
        public EfOnePost(UniPin_Context context) : base(context)
        {
        }

        public PostDTO Execute(int request)
        {
            var query = _context.Posts.AsQueryable();
            query = query.Where(c => c.Id == request).Include(s => s.Picture).Include(u => u.User).Include(co =>co.Comments);

            return query.Select(dto => new PostDTO
            {
                Id = dto.Id,
                Naslov = dto.Naslov,
                Opis = dto.Opis,
                CategoryName = dto.Category.Naziv,
                Picture = dto.Picture.Putanja,
                PostBy = dto.User.Ime,
                Comments = dto.Comments.Select(i => new CommentDTO
                {
                    Tekst = i.Tekst

                }).ToList()
              

            }).FirstOrDefault();

        }
    }
}
