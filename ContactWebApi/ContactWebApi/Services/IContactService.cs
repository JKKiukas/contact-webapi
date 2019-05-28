using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Services
{
    interface IContactService
    {
        ContactTable CreateContact(ContactTable contact);
        List<ContactTable> ReadContact();
        ContactTable ReadContact(int id);
        ContactTable UpdateContact(int id, ContactTable contact);
        void DeleteContact(int id);
    }
}
