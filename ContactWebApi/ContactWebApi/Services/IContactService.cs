using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Services
{
    public interface IContactService
    {
        ContactTable CreateContact(ContactTable contact);
        List<ContactTable> ReadContact();
        ContactTable ReadContact(long id);
        ContactTable UpdateContact(long id, ContactTable contact);
        void DeleteContact(long id);
    }
}
