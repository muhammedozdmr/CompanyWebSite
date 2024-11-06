using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaqAPIController : Controller
    {
        private readonly IFAQService _faqService;
        public FaqAPIController(IFAQService fAQService)
        {
            _faqService = fAQService;
        }

        [HttpGet]
        public async Task<IEnumerable<FAQDto>> GetAllFAQs(string languageCode = "tr")
        {
            return await _faqService.GetFAQAllAsync(languageCode);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FAQDto>> GetFAQById(int id)
        {
            var faq = await _faqService.GetFAQByIdAsync(id);
            if (faq == null)
            {
                return NotFound();
            }
            return Ok(faq);
        }

        [HttpPost]
        public async Task<IActionResult> AddFAQ([FromBody] FAQDto faqDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _faqService.AddFAQAsync(faqDto);
            return CreatedAtAction(nameof(GetFAQById), new { id = faqDto.Id }, faqDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFAQ([FromBody] FAQDto faqDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _faqService.UpdateFAQAsync(faqDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFAQ(int id)
        {
            await _faqService.DeleteFAQAsync(id);
            return NoContent();
        }
    }
}
