using AutoMapper;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Domain.Entities;
using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class ContactService : IContactService
    {
        private readonly IBaseRepository<Contact> _baseContactRepository;
        private readonly IMapper _mapper;
        public ContactService(IBaseRepository<Contact> baseContactRepository, IMapper mapper)
        {
            _baseContactRepository = baseContactRepository;
            _mapper = mapper;
        }

        //TODO: Contact da ContactDto kontrol et ContactForm işlemini unutma
        public async Task AddContactAsync(ContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);
            await _baseContactRepository.AddAsync(contact);
        }

        public async Task DeleteContactAsync(int id)
        {
            await _baseContactRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ContactDto>> GetContactAllAsync(string languageCode)
        {
            var contacts = await _baseContactRepository.GetAllAsync();
            var conatcsDtosMap = _mapper.Map<IEnumerable<ContactDto>>(contacts);
            return conatcsDtosMap;
        }

        public async Task<ContactDto> GetContactByIdAsync(int id)
        {
            var contact = await _baseContactRepository.GetByIdAsync(id);
            var contactDto = _mapper.Map<ContactDto>(contact);
            return contactDto;
        }

        public async Task UpdateContactAsync(ContactDto contactDto)
        {
            var contact = await _baseContactRepository.GetByIdAsync(contactDto.Id);
            if(contact != null)
            {
                contact = _mapper.Map<Contact>(contactDto);
                await _baseContactRepository.UpdateAsync(contact);
            }
            else
            {
                throw new Exception("Contact not found");
            }
        }
    }
}
