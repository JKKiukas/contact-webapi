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

        public Contact CreateContact(Contact contact)
        {
            return _contactRepository.Create(contact);
        }

        public void DeleteContact(long id)
        {
            _contactRepository.Delete(id);
        }

        public List<Contact> ReadContact()
        {
            return _contactRepository.Read();
        }

        public Contact ReadContact(long id)
        {
            return _contactRepository.Read(id);
        }

        public Contact UpdateContact(long id, Contact contact)
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

        public Contact UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
