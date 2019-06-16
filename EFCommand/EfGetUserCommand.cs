using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfGetUserCommand : IGetUserCommand
    {
        private readonly UniPin_Context _context;

        public EfGetUserCommand(UniPin_Context context)
        {
            _context = context;
        }

        public UserDTO Execute(int response)
        {
            var user = _context.Users.Find(response);
            if (user == null)
            {
                throw new EntityNotFoundException("User");
            }

            return new UserDTO
            {
                Id = user.Id,
                Ime = user.Ime,
                KorisnickoIme = user.KorisnickoIme,
                Lozinka = user.Lozinka,
                Prezime = user.Prezime,
                RuleId = user.RuleId
            };
        }
    }
}
