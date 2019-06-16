using Application.Interfaces;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public interface IloggedUserCommand : ICommand<Logged, LoggedUser>
    {
    }
}
