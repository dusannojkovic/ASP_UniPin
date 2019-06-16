using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Comment;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IGetAllCommentCommand _getAll;
        private readonly IGetOneCommentCommand _getOne;
        private readonly IDeleteCommentCommand _deleteComment;
        private readonly ICreateCommentCommand _create;
        private readonly IUpdateCommentCommand _update;

        public CommentController(IGetAllCommentCommand getAll, IGetOneCommentCommand getOne, IDeleteCommentCommand deleteComment, ICreateCommentCommand create, IUpdateCommentCommand update)
        {
            _getAll = getAll;
            _getOne = getOne;
            _deleteComment = deleteComment;
            _create = create;
            _update = update;
        }


        // GET: api/Commant
        [HttpGet]
        public ActionResult<IEnumerable<CommentDTO>> Get([FromQuery]CommentSearch search)
        {
            try
            {
                var comments = _getAll.Execute(search);
                return Ok(comments);
            }
            catch (EntityNotFoundException)
            {

                return NotFound();
            }

        }

        // GET: api/Commant/5
        [HttpGet("{id}")]
        public ActionResult<CommentDTO> Get(int id)
        {
            try
            {
                var comment = _getOne.Execute(id);
                return Ok(comment);
            }
            catch (EntityNotFoundException)
            {
                throw new EntityNotFoundException("Comment");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // POST: api/Commant
        [HttpPost]
        public ActionResult Post([FromBody] CommentDTO dto)
        {
            try
            {
                _create.Execute(dto);
            }
            catch
            {

                return StatusCode(500, "An error has occured.");
            }
            return Ok();
        }

        // PUT: api/Commant/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CommentDTO dto)
        {
            dto.Id = id;
            try
            {
                _update.Execute(dto);
                return NoContent();
            }
            catch (EntityNotFoundException e)
            {
                if (e.Message == "Product doesn't exist.")
                {
                    return NotFound(e.Message);
                }

                return UnprocessableEntity(e.Message);

            }
            catch (Exception e)
            {

                return StatusCode(500, "An error has occured.");
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _deleteComment.Execute(id);
                return NoContent();
            }
            catch (EntityNotFoundException)
            {

                return StatusCode(404, "Not found");
            }
        }
    }
}
