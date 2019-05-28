using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;
using ContactWebApi.Repositories;

namespace ContactWebApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public ContactTable CreateContact(ContactTable contact)
        {
            return _contactRepository.Create(contact);
        }

        public void DeleteContact(int id)
        {
            _contactRepository.Delete(id);
        }

        public List<ContactTable> ReadContact()
        {
            return _contactRepository.Read();
        }

        public ContactTable ReadContact(int id)
        {
            return _contactRepository.Read(id);
        }

        public ContactTable UpdateContact(int id, ContactTable contact)
        {
            var updateContact = _contactRepository.Read(id);
            if (updateContact == null)
            {
                throw new Exception("Contact was not found");
            }

            else
            {
                return _contactRepository.Update(contact);
            }
        }

        public ContactTable UpdateContact(ContactTable contact)
        {
            throw new NotImplementedException();
        }
    }
}
