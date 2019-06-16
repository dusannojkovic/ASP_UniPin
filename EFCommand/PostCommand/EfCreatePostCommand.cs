using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfCreatePostCommand : EfBaseCommand, ICreatePostCommand
    {
        public EfCreatePostCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(PostDTO request)
        {
            if (_context.Posts.Any(p => p.Naslov == request.Naslov && p.Opis == request.Opis))
            {
                throw new EntityAlreadyExistsException("Post");
            }
            _context.Posts.Add(new Post
            {
                CreatedAt = DateTime.Now,
                Naslov = request.Naslov,
                Opis = request.Opis,
                PictureId = request.PictureId,
                CategoryId = request.CategoryId,
                UserId = request.UserId,
                
                IsDeleted = false
            });
            _context.SaveChanges();
        }

    }
}
