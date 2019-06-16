using Application.Commands.Comment;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CommentCommand
{
    public class EfDeleteCommentCommand : EfBaseCommand, IDeleteCommentCommand
    {
        public EfDeleteCommentCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var comment = _context.Comments.Find(request);
            if(comment == null)
            {
                throw new EntityNotFoundException("Comment");
            }
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}
