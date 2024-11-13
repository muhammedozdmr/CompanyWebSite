using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactAPIController : Controller
    {
        private readonly IContactService _contactService;
        public ContactAPIController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IEnumerable<ContactDto>> GetAllContacts(string languageCode = "tr")
        {
            return await _contactService.GetContactAllAsync(languageCode);
        }

        [HttpPost]
        public async Task<IActionResult> AddContactFormFromContact([FromBody] ContactFormDto contactFormDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _contactService.AddContactAsync(contactFormDto);
            return CreatedAtAction(nameof(GetAllContacts), new { id = contactFormDto.Id }, contactFormDto);
        }
    }
}
