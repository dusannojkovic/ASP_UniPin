using Application.DTO;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Comment
{
    public interface IUpdateCommentCommand : ICommand<CommentDTO>
    {
    }
}
