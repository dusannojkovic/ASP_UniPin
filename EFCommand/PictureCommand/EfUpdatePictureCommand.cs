using Application.Commands.Picture;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PictureCommand
{
    public class EfUpdatePictureCommand : EfBaseCommand, IUpdatePictureCommand
    {
        public EfUpdatePictureCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(PictureDTO request)
        {
            var picture = _context.Pictures.Find(request.id);

            if (picture == null)
            {
                throw new EntityNotFoundException("Picture");
            }


            picture.Id = request.id;
            picture.CreatedAt = DateTime.Now;
            picture.Putanja = request.Putanja;
            picture.Alt = request.Alt;

            _context.SaveChanges();

           
        }
    }
}
