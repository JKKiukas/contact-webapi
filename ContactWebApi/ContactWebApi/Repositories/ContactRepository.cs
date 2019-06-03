using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactWebApi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactWebapiContext _context;

        public ContactRepository(ContactWebapiContext context)
        {
            _context = context;
        }

        public ContactTable Create(ContactTable contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public void Delete(long id)
        {
            var deleteContact = Read(id);
            _context.Remove(deleteContact);
            _context.SaveChanges();
            return;
        }

        public List<ContactTable> Read()
        {
            return _context.ContactTable.AsNoTracking().ToList();
        }

        public ContactTable Read(long id)
        {
            return _context.ContactTable.FirstOrDefault(c => c.Id == id);
        }

        public ContactTable Update(ContactTable contact)
        {
            _context.Update(contact);
            _context.SaveChanges();
            return contact;
        }
    }
}
