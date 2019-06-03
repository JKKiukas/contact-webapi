using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Repositories
{
    public interface IContactRepository
    {
        ContactTable Create(ContactTable contact);
        List<ContactTable> Read();
        ContactTable Read(long id);
        ContactTable Update(ContactTable contact);
        void Delete(long id);
    }
}
