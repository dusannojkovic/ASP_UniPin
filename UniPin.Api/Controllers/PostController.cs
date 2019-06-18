using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
using Application.Interfaces;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ICreatePostCommand _createPost;
        private readonly IGetAllPostCommand _getAllPost;
        private readonly IGetOnePostCommand _getOnePost;
        private readonly IDeletePostCommand _deletePost;
        private readonly IUpdatePostCommand _updatePost;
        private IEmailSender sender;

        public PostController(ICreatePostCommand createPost, IGetAllPostCommand getAllPost, IGetOnePostCommand getOnePost, IDeletePostCommand deletePost, IUpdatePostCommand updatePost, IEmailSender sender)
        {
            _createPost = createPost;
            _getAllPost = getAllPost;
            _getOnePost = getOnePost;
            _deletePost = deletePost;
            _updatePost = updatePost;
            this.sender = sender;
        }



        /// <summary>
        /// Vraca sve postove, slike postova i listu komentara vezanih za taj post
        /// Mogucnost pretrage po naslovu, opisu, paginacija, po imenu autora posta
        /// </summary>
        // GET: api/Post
        [HttpGet]
        public ActionResult<IEnumerable<PostDTO>> Get([FromQuery] PostSearch search)
        {
            try
            {
                var post = _getAllPost.Execute(search);
                return Ok(post);
            }
            catch (EntityNotFoundException)
            {

                return NotFound();
            }
        }

        /// <summary>
        /// Vraca jedan post i sve detalje o njemu
        /// </summary>
        // GET: api/Post/5
        [HttpGet("{id}")]
        public ActionResult<PostDTO> Get(int id)
        {
            try
            {
                var postDto = _getOnePost.Execute(id);
                return Ok(postDto);
            }
            catch (EntityNotFoundException)
            {
                throw new EntityNotFoundException("Post");
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Ubacivanje posta u bazi
        /// </summary>
        // POST: api/Post
        [HttpPost]
        public ActionResult Post([FromQuery] PostDTO dto, string email)
        {
            try
            {
                _createPost.Execute(dto);
                sender.Subject = "Kreiranje posta";
                sender.ToEmail = email;
                sender.Body = "Uspesno ste uneli post! :D";
                sender.Send();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return Ok();
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PostDTO dto,string email)
        {
            dto.Id = id;
            try
            {
                if(id != 0)
                {
                    throw new Exception("Not Found");
                }
                 _updatePost.Execute(dto);
                sender.Subject = "Izmena posta";
                sender.ToEmail = email;
                sender.Body = "Uspesno ste izmenili post! :D";
                sender.Send();
                return NoContent();
            }
            catch (EntityNotFoundException e)
            {
                if (e.Message == "Post doesn't exist.")
                {
                    return NotFound(e.Message);
                }

                return UnprocessableEntity(e.Message);

            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message );
            }

        }
        /// <summary>
        /// Brisanje odredjenog posta iz baze
        /// </summary>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _deletePost.Execute(id);
                return NoContent();
            }
           catch (EntityNotFoundException)
            {

                return StatusCode(404, "Not found");
            }
          
        }
    }
}
