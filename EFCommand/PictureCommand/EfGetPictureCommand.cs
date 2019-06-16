using Application.Commands.Picture;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PictureCommand
{
    public class EfGetPictureCommand : EfBaseCommand, IGetPictureCommand
    {
        public EfGetPictureCommand(UniPin_Context context) : base(context)
        {
        }

        public PictureDTO Execute(int request)
        {
            var picture = _context.Pictures.Find(request);

            if (picture == null)
            {
                throw new EntityNotFoundException("Picture");
            }

            return new PictureDTO
            {
                Alt = picture.Alt,
                Putanja = picture.Putanja
            };
        }
    }
}
