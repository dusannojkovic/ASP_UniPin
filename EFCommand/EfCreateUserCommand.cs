using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfCreateUserCommand : EfBaseCommand, ICreateUserCommand
    {
        public EfCreateUserCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(UserDTO request)
        {
            if(_context.Users.Any(u => u.KorisnickoIme == request.KorisnickoIme))
            {
                throw new EntityAlreadyExistsException("User");
            }
            _context.Users.Add(new User
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                KorisnickoIme = request.KorisnickoIme,
                CreatedAt = DateTime.Now,
                Lozinka = request.Lozinka,
                RuleId = 2
            });
            _context.SaveChanges();
        }
    }
}
