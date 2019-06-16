using Application.Commands.Picture;
using Application.DTO;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.PictureCommand
{
    public class EfGetAllPictureCommand : EfBaseCommand, IGetAllPictureCommand
    {
        public EfGetAllPictureCommand(UniPin_Context context) : base(context)
        {
        }

        public ICollection<PictureDTO> Execute(PictureSearch request)
        {
            var query = _context.Pictures.AsQueryable();

            if(request.Alt != null)
            {
                query.Where(p => p.Alt.ToLower().Contains(request.Alt.ToLower()));
            }
            return query.Select(pc => new PictureDTO
            {
                id = pc.Id,
                Alt = pc.Alt,
                Putanja = pc.Putanja
            }).ToList();
        }
    }
}
