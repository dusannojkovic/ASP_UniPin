using Application;
using Application.Commands;
using Application.Exceptions;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfLoggedUserCommand : EfBaseCommand, IloggedUserCommand
    {
        public EfLoggedUserCommand(UniPin_Context context) : base(context)
        {
        }

        public LoggedUser Execute(Logged request)
        {
            var user = _context.Users.AsQueryable();

            if (!_context.Users.Any(u => u.KorisnickoIme.ToLower() == request.Username.ToLower()))
            {
                throw new EntityNotFoundException("User");
            }
            if (!_context.Users.Any(u => u.Lozinka.ToLower() == request.Password.ToLower()))
            {
                throw new EntityNotFoundException("User");
            }

            user = user.Where(use => use.Lozinka == request.Password && use.KorisnickoIme == request.Username);
            return user.Select(us => new LoggedUser
            {
                Id = us.Id,
                FirstName = us.Ime,
                LastName = us.Prezime,
                Role = us.Rule.Naziv,
                Password = us.Lozinka,
                Username = us.KorisnickoIme
            }).FirstOrDefault();

        }
    }
}
