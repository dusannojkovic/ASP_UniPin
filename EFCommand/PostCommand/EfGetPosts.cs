using Application.Commands.Post;
using Application.DTO;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfGetPosts : EfBaseCommand, IGetPosts
    {
        public EfGetPosts(UniPin_Context context) : base(context)
        {
        }

        public IEnumerable<PostDTO> Execute(PostSearch request)
        {
            var postDto = _context.Posts.AsQueryable();

            if (request.Id != null)
            {
                postDto = postDto.Where(p => p.Id == request.Id);
            }
            if (request.Naslov != null)
            {
                postDto = postDto.Where(p => p.Naslov.ToLower().Contains(request.Naslov.ToLower()));
            }
            if (request.Opis != null)
            {
                postDto = postDto.Where(p => p.Opis.ToLower().Contains(request.Opis.ToLower()));
            }

            return postDto.Select(p => new PostDTO
            {
                Id = p.Id,
                Naslov = p.Naslov,
                Opis = p.Opis,
                Picture = p.Picture.Putanja,
                CategoryName = p.Category.Naziv,
                PostBy = p.User.Ime

            });

        }
    }
}
