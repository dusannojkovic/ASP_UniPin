using Application.Commands.Picture;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PictureCommand
{
    public class EfDeletePictureCommand : EfBaseCommand, IDeletePictureCommand
    {
        public EfDeletePictureCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var picture = _context.Pictures.Find(request);
            if (picture == null)
            {
                throw new EntityNotFoundException("Picture");
            }

            _context.Pictures.Remove(picture);
            _context.SaveChanges();
        }
    }
}
