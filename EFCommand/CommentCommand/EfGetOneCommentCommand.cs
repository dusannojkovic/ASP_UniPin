using Application.Commands.Comment;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CommentCommand
{
    public class EfGetOneCommentCommand : EfBaseCommand, IGetOneCommentCommand
    {
        public EfGetOneCommentCommand(UniPin_Context context) : base(context)
        {
        }

        public CommentDTO Execute(int request)
        {
            var comment = _context.Comments.Find(request);

            if(comment == null)
            {
                throw new EntityNotFoundException("Comment");
            }

            return new CommentDTO
            {
                Tekst = comment.Tekst,
                PostByUser = comment.User.Ime,
                PostId = comment.PostId,
                UserId = comment.UserId
            };
        }
    }
}
