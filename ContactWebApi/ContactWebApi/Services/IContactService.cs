using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Services
{
    public interface IContactService
    {
        Contact CreateContact(Contact contact);
        List<Contact> ReadContact();
        Contact ReadContact(long id);
        Contact UpdateContact(long id, Contact contact);
        void DeleteContact(long id);
    }
}
