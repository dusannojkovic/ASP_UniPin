using Application.Commands.Post;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfDeletePostCommand : EfBaseCommand, IDeletePostCommand
    {
        public EfDeletePostCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var postDto = _context.Posts.Find(request);
            if(postDto == null)
            {
                throw new EntityNotFoundException("Post");
            }

            _context.Posts.Remove(postDto);
            _context.SaveChanges();
        }
    }
}
