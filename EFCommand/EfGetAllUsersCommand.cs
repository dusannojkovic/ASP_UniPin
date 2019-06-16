using Application.Commands;
using Application.DTO;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfGetAllUsersCommand : EfBaseCommand, IGetAllUsersCommand
    {
        public EfGetAllUsersCommand(UniPin_Context context) : base(context)
        {
        }

        public ICollection<UserDTO> Execute(UserSearch request)
        {
            var query = _context.Users.AsQueryable();
            if (request.Ime != null)
            {
                query = query.Where(u => u.Ime
                .ToLower()
                .Contains(request.Ime.ToLower()));
            }
            if (request.Prezime != null)
            {
                query = query.Where(u => u.Prezime
                .ToLower()
                .Contains(request.Prezime.ToLower()));
            }
            return query.Select(c => new UserDTO
            {
                Id = c.Id,
                Ime = c.Ime,
                KorisnickoIme = c.KorisnickoIme,
                Lozinka = c.Lozinka,
                Prezime = c.Prezime,
                RuleId = c.RuleId
            }).ToList();

        }
    }
}
