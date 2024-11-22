using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogAPIController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogAPIController(IBlogService blogService)
        {
            _blogService = blogService;
        }


        [HttpGet]
        public async Task<IEnumerable<BlogDto>> GetAllBlogs (string languageCode = "tr")
        {
            return await _blogService.GetBlogAllAsync(languageCode);
        }


        //Bunu düzenle dil bilgisi de alman gerek !
        [HttpGet("{id}")]
        public async Task<ActionResult<BlogDto>> GetBlogById(string languageCode, int id)
        {
            var blog = await _blogService.GetBlogByIdAsync(languageCode,id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog([FromBody] BlogDto blogDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _blogService.AddBlogAsync(blogDto);
            return CreatedAtAction(nameof(GetBlogById), new { id = blogDto.Id }, blogDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog([FromBody] BlogDto blogDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _blogService.UpdateBlogAsync(blogDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.DeleteBlogAsync(id);
            return NoContent();
        }
    }
}
