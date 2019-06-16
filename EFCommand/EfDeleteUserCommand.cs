using Application.Commands;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public class EfDeleteUserCommand : EfBaseCommand,IDeleteUserCommand
    {
        public EfDeleteUserCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var user = _context.Users.Find(request);
            if(user == null)
            {
                throw new EntityNotFoundException("User");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
