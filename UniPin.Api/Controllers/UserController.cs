using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IGetUserCommand _getUserCommand;
        private IGetAllUsersCommand _getAllUser;
        private IDeleteUserCommand _deleteUser;
        private ICreateUserCommand _createUser;
        private IUpdateUserCommand _updateUser;

        public UserController(IGetUserCommand getUserCommand, IGetAllUsersCommand getAllUser, IDeleteUserCommand deleteUser, ICreateUserCommand createUser, IUpdateUserCommand updateUser)
        {
            _getUserCommand = getUserCommand;
            _getAllUser = getAllUser;
            _deleteUser = deleteUser;
            _createUser = createUser;
            _updateUser = updateUser;
        }


        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> Get([FromQuery] UserSearch search)
        {
            try
            {
                var users = _getAllUser.Execute(search);
                return Ok(users);
            }
            catch (EntityNotFoundException)
            {

                return NotFound();
            }        
            
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public ActionResult<UserDTO> Get(int id)
        {
            try
            {
                var userDto = _getUserCommand.Execute(id);
                return Ok(userDto);
            }
            catch (EntityNotFoundException)
            {
                throw new EntityNotFoundException("User");
            }
            catch (Exception)
            {
                throw;
            }

        }

        // POST: api/User
        [HttpPost]
        public ActionResult Post([FromBody] UserDTO dto)
        {
          
            try
            {
                _createUser.Execute(dto);
            }
            catch 
            {

                return StatusCode(500, "An error has occured.");
            }
            return Ok();
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] UserDTO dto)
        {
            dto.Id = id;
            try
            {
                _updateUser.Execute(dto);
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

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _deleteUser.Execute(id);
                return NoContent();
            }
            catch (EntityNotFoundException)
            {

                return StatusCode(404,"Not found");
            }
           
        }
    }
}
