using Application.Commands.Post;
using Application.DTO;
using Application.Respones;
using Application.Searches;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfGetAllPostCommand : EfBaseCommand, IGetAllPostCommand
    {
        public EfGetAllPostCommand(UniPin_Context context) : base(context)
        {
        }

        public PagedResponse<PostDTO> Execute(PostSearch request)
        {
            var postDto = _context.Posts.AsQueryable();

            if(request.Id != null)
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

            var totalCount = postDto.Count();

            postDto = postDto.Skip((request.PageNumber - 1)*request.PerPage)
                             .Take(request.PerPage);

            
            var pagesCount = (int)Math.Ceiling((double)totalCount / request.PerPage);
            var respones = new PagedResponse<PostDTO>
            {
                CurrentPage = request.PageNumber,
                TotalCount = totalCount,
                PagesCount = pagesCount,
                Data = postDto.Select(p => new PostDTO
                {
                    Id = p.Id,
                    Naslov = p.Naslov,
                    Opis = p.Opis,
                    Picture = p.Picture.Putanja,
                    CategoryName = p.Category.Naziv,
                    PostBy = p.User.Ime 
                    
                })
            };

            return respones;
        }
        
    }
}
