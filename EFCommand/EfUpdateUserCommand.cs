using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfUpdateUserCommand : EfBaseCommand, IUpdateUserCommand
    {
        public EfUpdateUserCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(UserDTO request)
        {
            var user = _context.Users.Find(request.Id);

            if(user == null)
            {
                throw new EntityNotFoundException("User");
            }
            if(user.KorisnickoIme != request.KorisnickoIme)
            {
                if(_context.Users.Any(u => u.KorisnickoIme == request.KorisnickoIme))
                {
                    throw new EntityAlreadyExistsException("User");
                }

                user.Id = request.Id;
                user.Ime = request.Ime;
                user.KorisnickoIme = request.KorisnickoIme;
                user.Lozinka = request.Lozinka;
                user.Prezime = request.Prezime;
                user.RuleId = request.RuleId;

                _context.SaveChanges();

            }
        }
    }
}
