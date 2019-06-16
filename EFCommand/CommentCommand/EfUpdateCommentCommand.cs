using Application.Commands.Comment;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CommentCommand
{
    public class EfUpdateCommentCommand : EfBaseCommand, IUpdateCommentCommand
    {
        public EfUpdateCommentCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(CommentDTO request)
        {
            var comment = _context.Comments.Find(request.Id);

            if (comment.Tekst.ToLower().Contains(request.Tekst.ToLower()))
            {
                throw new EntityAlreadyExistsException("Comment");
            }
            comment.Tekst = request.Tekst;
            comment.PostId = request.PostId;
            comment.UserId = request.UserId;

            _context.SaveChanges();
        }
    }
}
