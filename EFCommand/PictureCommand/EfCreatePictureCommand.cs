using Application.Commands.Picture;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PictureCommand
{
    public class EfCreatePictureCommand : EfBaseCommand, ICreatePictureCommand
    {
        public EfCreatePictureCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(PictureDTO request)
        {
            _context.Pictures.Add(new Domain.Picture
            {
                Alt = request.Alt,
                CreatedAt = DateTime.Now,
                Putanja = request.Putanja
            });

            _context.SaveChanges();
        }
    }
}
