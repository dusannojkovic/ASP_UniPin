﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
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

        public PostController(ICreatePostCommand createPost, IGetAllPostCommand getAllPost, IGetOnePostCommand getOnePost, IDeletePostCommand deletePost, IUpdatePostCommand updatePost)
        {
            _createPost = createPost;
            _getAllPost = getAllPost;
            _getOnePost = getOnePost;
            _deletePost = deletePost;
            _updatePost = updatePost;
        }


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

        // POST: api/Post
        [HttpPost]
        public ActionResult Post([FromBody] PostDTO dto)
        {
            try
            {
                _createPost.Execute(dto);
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return Ok();
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PostDTO dto)
        {
            dto.Id = id;
            try
            {
                if(id != 0)
                {
                    throw new Exception("Not Found");
                }
                 _updatePost.Execute(dto);
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