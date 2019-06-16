using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfGetOnePostCommand : EfBaseCommand, IGetOnePostCommand
    {
        public EfGetOnePostCommand(UniPin_Context context) : base(context)
        {
        }

        public PostDTO Execute(int request)
        {
            var postDto = _context.Posts.Find(request);

            if(postDto == null)
            {
                throw new EntityNotFoundException("Post");
            }

            return new PostDTO
            {

                Id = postDto.Id,
                Naslov = postDto.Naslov,
                Opis = postDto.Opis,
                //PostBy = postDto.User.Ime,
                //CategoryName = postDto.Category.Naziv,
                //Picture = postDto.Picture.Putanja
            };
        }
    }
}
