using Application.Commands;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfAllUser : EfBaseCommand, IAllUser
    {
        public EfAllUser(UniPin_Context context) : base(context)
        {
        }

        public ICollection<UserDTO> Execute(UserDTO request)
        {
            var users = _context.Users.AsQueryable();
            return users.Select(c => new UserDTO
            {
                Id = c.Id,
                Ime = c.Ime
            }).ToList();
        }
    }
}
