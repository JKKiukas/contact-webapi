using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactWebApi.Models;
using ContactWebApi.Repositories;
using ContactWebApi.Services;

namespace ContactWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        private readonly IContactService _contactService;

        public ContactsController(IContactRepository contactRepository, IContactService contactService)
        {
            _contactRepository = contactRepository;
            _contactService = contactService;
        }
        
        // GET api/contacts
        [HttpGet]
        public ActionResult<List<Contact>> GetContacts()
        {
            return new JsonResult(_contactService.ReadContact());
        }

        // GET api/Contacts/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(long id)
        {
            var contact = _contactService.ReadContact(id);
            return new JsonResult(contact);
        }

        // POST api/Contact
        [HttpPost]
        public ActionResult<Contact> Post(Contact contact)
        {
            var newContact = _contactService.CreateContact(contact);
            return new JsonResult(newContact);
        }

        // PUT api/Contacts/5
        [HttpPut("{id}")]
        public ActionResult<Contact> Put(long id, Contact contact)
        {
            var updateContact = _contactService.UpdateContact(id, contact);
            return new JsonResult(updateContact);
        }

        // DELETE api/Contacts/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            return _contactService.DeleteContact(id);
        }
    }
}