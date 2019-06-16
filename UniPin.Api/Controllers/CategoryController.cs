using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Category;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICreateCategoryCommand _createCategory;
        private IGetAllCategoryCommand _getAllCategory;
        private IGetOneCategoryCommand _getOneCategory;
        private IDeleteCategoryCommand _deleteCategory;
        private IUpdateCategoryCommand _updateCategory;

        public CategoryController(ICreateCategoryCommand createCategory, IGetAllCategoryCommand getAllCategory, IGetOneCategoryCommand getOneCategory, IDeleteCategoryCommand deleteCategory, IUpdateCategoryCommand updateCategory)
        {
            _createCategory = createCategory;
            _getAllCategory = getAllCategory;
            _getOneCategory = getOneCategory;
            _deleteCategory = deleteCategory;
            _updateCategory = updateCategory;
        }


        /// <summary>
        /// Return ALL CATEGORIES
        /// </summary>


        // GET: api/Category
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> Get([FromQuery] CategorySearch search)
        {
            try
            {
                var categories = _getAllCategory.Execute(search);
                return Ok(categories);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Return ONE CATEGORY
        /// </summary>
        // GET: api/Category/5
        [HttpGet("{id}")]
        public ActionResult<CategoryDTO> Get(int id)
        {
            try
            {
                var categoryDto = _getOneCategory.Execute(id);
                return Ok(categoryDto);
            }
            catch (EntityNotFoundException)
            {
                throw new EntityNotFoundException("Category");
              
            }
        }

        // POST: api/Category
        [HttpPost]
        public ActionResult Post([FromBody] CategoryDTO dto)
        {
            try
            {
                _createCategory.Execute(dto);
            }
            catch
            {
                return StatusCode(500, "An error has occured.");
            }
            return Ok();
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromQuery] CategoryDTO dto)
        {
            dto.Id = id;
            try
            {
                _updateCategory.Execute(dto);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                if (e.Message == "Product doesn't exist.")
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
                _deleteCategory.Execute(id);
                return NoContent();
            }
            catch (EntityNotFoundException)
            {
                return StatusCode(404, "Not found");
            }
        }
    }
}
