using Backend_ShortedUrl.Models;
using Backend_ShortedUrl.Models.Datos;
using Backend_ShortedUrl.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ShortedUrl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShortedURLController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<IEnumerable<URLDto>> GetAll()
        {
            return Ok(URLStore.urlList);
        } 

        [HttpGet("id:int")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<URLDto> GetById(int id)
        {
            var result = URLStore.urlList.FirstOrDefault(url => url.Id == id);

            if (result == null)
            {
                return NotFound("El ID no coincide con algún resultado en la búsqueda");
            }
                        
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<URLDto> CrearURL([FromBody] URLDto url)
        {
            if (url == null)
            {
                return BadRequest("Los datos enviados no son correctos.");
            }

            var result = URLStore.urlList.FirstOrDefault(url => url.Id == url.Id);

            if (result != null && result.Id == url.Id)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            url.Id = URLStore.urlList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1; 
            return Ok(url);
        }
    }
}
