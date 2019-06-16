using Application.DTO;
using Application.Interfaces;
using Application.Respones;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Post
{
    public interface IGetAllPostCommand : ICommand<PostSearch, PagedResponse<PostDTO>>
    {
    }
}
