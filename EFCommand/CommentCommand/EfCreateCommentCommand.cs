using Application.Commands.Comment;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CommentCommand
{
    public class EfCreateCommentCommand : EfBaseCommand, ICreateCommentCommand
    {
        public EfCreateCommentCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(CommentDTO request)
        {
            _context.Comments.Add(new Domain.Comment
            {
                PostId = request.PostId,
                Tekst = request.Tekst,
                UserId = request.UserId
            });

            _context.SaveChanges();
        }
    }
}
