using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Picture;
using Application.DTO;
using Application.Exceptions;
using Application.Helpers;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        private ICreatePictureCommand _createPicture;
        private IGetAllPictureCommand _getAllPicture;
        private IGetPictureCommand _getPicture;
        private IUpdatePictureCommand _updatePicture;
        private IDeletePictureCommand _deletePicture;

        public PictureController(ICreatePictureCommand createPicture, IGetAllPictureCommand getAllPicture, IGetPictureCommand getPicture, IUpdatePictureCommand updatePicture, IDeletePictureCommand deletePicture)
        {
            _createPicture = createPicture;
            _getAllPicture = getAllPicture;
            _getPicture = getPicture;
            _updatePicture = updatePicture;
            _deletePicture = deletePicture;
        }






        /// <summary>
        /// Vraca sve slike iz baze
        /// Mogucnost pretrage po altu
        /// </summary>


        // GET: api/Picture
        [HttpGet]
        public ActionResult<IEnumerable<PictureDTO>> Get([FromQuery]PictureSearch search)
        {
            try
            {
                var slike = _getAllPicture.Execute(search);
                return Ok(slike);


            }
            catch (EntityNotFoundException)
            {

                return NotFound();
            }
        }

        /// <summary>
        /// Vraca jednu sliku sa opisom
        /// </summary>
        // GET: api/Picture/5
        [HttpGet("{id}")]
        public ActionResult<PictureDTO> Get(int id)
        {
            try
            {
                var pictureDto = _getPicture.Execute(id);
                return Ok(pictureDto);
            }
            catch (EntityNotFoundException)
            {
                throw new EntityNotFoundException("Picture");
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Ubacivanje slike u bazu
        /// Format unosa je 
        /// {
        ///   "alt": "string",
        ///   "Image": "file"
        /// }
        /// </summary>

        // POST: api/Picture
        [HttpPost]
        public ActionResult Post([FromForm] CreatePicture pic)
        {
            var ext = Path.GetExtension(pic.Image.FileName);
            if (!FileUpload.AllowExtension.Contains(ext))
            {
                return UnprocessableEntity("Image extension is not allowed.");
            }
            try
            {
                var newFileName = Guid.NewGuid().ToString() + "_" + pic.Image.FileName;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload", newFileName);
                pic.Image.CopyTo(new FileStream(filePath, FileMode.Create));


                var dto = new PictureDTO
                {
                    Alt = pic.Alt,
                    Putanja = newFileName
                };
                _createPicture.Execute(dto);
                return NoContent();
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

            
       
         

        }

        // PUT: api/Picture/5
        [HttpPut("{id}")]
        public ActionResult<PictureDTO> Put(int id, [FromForm] PictureDTO dto)
        {
            dto.id = id;
            try
            {
                _updatePicture.Execute(dto);
                return NoContent();
            }
            catch (EntityNotFoundException e)
            {
                if (e.Message == "Picture doesn't exist.")
                {
                    return NotFound(e.Message);
                }

                return UnprocessableEntity(e.Message);

            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        /// <summary>
        /// Brisanje odredjene slike iz baze
        /// </summary>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _deletePicture.Execute(id);
                return NoContent();
            }
            catch (EntityNotFoundException)
            {

                return StatusCode(404, "Not found");
            }
        }
    }
}
