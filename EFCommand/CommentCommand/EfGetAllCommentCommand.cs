using Application.Commands.Comment;
using Application.DTO;
using Application.Searches;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CommentCommand
{
    public class EfGetAllCommentCommand : EfBaseCommand, IGetAllCommentCommand
    {
        public EfGetAllCommentCommand(UniPin_Context context) : base(context)
        {
        }

        public ICollection<CommentDTO> Execute(CommentSearch request)
        {
            var query = _context.Comments.AsQueryable();
            //query = query.Include(po => po.Post);

            if(request.User_name != null)
            {
                query = query.Where(c => c.Post.User.Ime.ToLower().Contains(request.User_name.ToLower()));
            }
            if(request.Id != 0)
            {
                query = query.Where(c => c.Id == request.Id);
            }

            return query.Select(com => new CommentDTO
            {
                Id = com.Id,
                Tekst = com.Tekst,
                PostByUser = com.Post.User.Ime,
                PostId = com.PostId

            }).ToList();

        }
    }
}
