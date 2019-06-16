using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Post
{
    public interface IDeletePostCommand : ICommand<int>
    {
    }
}
