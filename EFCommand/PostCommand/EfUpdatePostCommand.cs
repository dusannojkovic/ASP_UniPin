using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfUpdatePostCommand : EfBaseCommand, IUpdatePostCommand
    {
        public EfUpdatePostCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(PostDTO request)
        {
            var postDto = _context.Posts.Find(request.Id);

            if (postDto == null)
            {
                throw new EntityNotFoundException("Post");
            }
            if(postDto.Naslov.ToLower() != request.Naslov.ToLower())
            {
                if(_context.Posts.Any(po => po.Naslov == request.Naslov && po.Opis == request.Opis))
                {
                    throw new EntityAlreadyExistsException("Post");
                }

     
                postDto.Naslov = request.Naslov;
                postDto.Opis = request.Opis;
                postDto.PictureId = request.PictureId;
                //postDto.UserId = request.UserId;
                postDto.CategoryId = request.CategoryId;

                _context.SaveChanges();
            }
        }
    }


}
