using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<IEnumerable<AboutDto>> GetAllAbouts(string languageCode = "tr")
        {
            return await _aboutService.GetAboutAllAsync(languageCode);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AboutDto>> GetAboutById(int id)
        {
            var about = await _aboutService.GetAboutByIdAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return Ok(about);
        }

        [HttpPost]
        public async Task<IActionResult> AddAbout([FromBody] AboutDto aboutDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _aboutService.AddAboutAsync(aboutDto);
            return CreatedAtAction(nameof(GetAboutById), new { id = aboutDto.Id }, aboutDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAbout(int id, [FromBody] AboutDto aboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _aboutService.UpdateAboutAsync(aboutDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAboutAsync(id);
            return NoContent();
        }
    }
}
