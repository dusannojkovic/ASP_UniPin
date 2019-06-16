using Application.Commands.Post;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PostCommand
{
    public class EfCreatePostPictureCommand : EfBaseCommand, ICreatePostCommand
    {
        public EfCreatePostPictureCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(PostDTO request)
        {
            var slika = new Domain.Picture
            {
                CreatedAt = DateTime.Now,
                Putanja = request.Picture
            };
            _context.Pictures.Add(slika);
            _context.SaveChanges();
            var pictureId = slika.Id;

            var post = _context.Posts.Add(new Domain.Post
            {
                CategoryId = request.CategoryId,
                Naslov = request.Naslov,
                Opis = request.Opis,
                PictureId = pictureId,
                UserId = request.UserId,
                CreatedAt = DateTime.Now,
                IsDeleted = false
                
            });

            _context.SaveChanges();


            
        }
    }
}
