using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Rule;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuleController : ControllerBase
    {

        private ICreateRuleCommand _createRule;
        private IGetAllRuleCommand _getAllRule;
        private IDeleteRuleCommand _deleteRule;
        private IGetOneRuleCommand _getOneRule;
        private IUpdateRuleCommand _updateRule;

        public RuleController(ICreateRuleCommand createRule, IGetAllRuleCommand getAllRule, IDeleteRuleCommand deleteRule, IGetOneRuleCommand getOneRule, IUpdateRuleCommand updateRule)
        {
            _createRule = createRule;
            _getAllRule = getAllRule;
            _deleteRule = deleteRule;
            _getOneRule = getOneRule;
            _updateRule = updateRule;
        }


        // GET: api/Rule
        [HttpGet]
        public ActionResult<IEnumerable<RuleDTO>> Get([FromBody]RuleSearch search)
        {
            try
            {
                var rule = _getAllRule.Execute(search);
                return Ok(rule);
            }
            catch (EntityNotFoundException)
            {

                return NotFound();
            }
            catch(Exception)
            {

                return StatusCode(500, "An error has occured.");
            }
        }

        // GET: api/Rule/5
        [HttpGet("{id}")]
        public ActionResult<RuleDTO> Get(int id)
        {
            try
            {
                var userDto = _getOneRule.Execute(id);
                return Ok(userDto);
            }
            catch (EntityNotFoundException)
            {

                throw new EntityNotFoundException("Role");
            }
            catch
            {

                return NotFound();
            }
        }

        // POST: api/Rule
        [HttpPost]
        public ActionResult Post([FromBody] RuleDTO dto)
        {
            try
            {
                _createRule.Execute(dto);
                return Ok();
            }
            catch
            {

                return StatusCode(500, "An error has occured.");
            }

        }

        // PUT: api/Rule/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RuleDTO dto)
        {
            dto.Id = id;

            try
            {
                _updateRule.Execute(dto);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                if (e.Message == "Rule doesn't exist.")
                {
                    return NotFound(e.Message);
                }

                return UnprocessableEntity(e.Message);

            }
            catch (Exception)
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
                _deleteRule.Execute(id);
                return NoContent();
            }
            catch (EntityNotFoundException)
            {

                throw;
            }
            catch
            {

                return StatusCode(404, "Not Found!!");
            }


        }
    }
}
