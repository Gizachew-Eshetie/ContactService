using ContactRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactRepository myContactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            this.myContactRepository = contactRepository;
        }
        [HttpGet]
        public JsonResult Get()
        {
            List<Contact> Contacts = myContactRepository.GetContacts();
            try
            {
                return Json(Contacts);
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        [Route("GetContactById")]
        public JsonResult Get(int Id)
        {
           Contact Contact = myContactRepository.GetContact(Id);
            try
            {
                return Json(Contact);
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        [Route("GetContactByEmailPhoneNumber")]
        public JsonResult GetContactByEmailPhoneNumber(string EmailOrPhoneNo)
        {
            Contact Contact = myContactRepository.GetContactByEmailPhoneNumber(EmailOrPhoneNo);

            try
            {
                return Json(Contact);
            }
            catch
            {
                return null;
            }
        }

        [HttpGet]
        [Route("GetContactsByStateCity")]
        public JsonResult GetContactsByStateCity(string StateOrCity)
        {
            List<Contact> Contacts = myContactRepository.GetContactsByStateCity(StateOrCity);
            try
            {
                return Json(Contacts);
            }
            catch
            {
                return null;
            }
        }
        [HttpPost]
        public void Post([FromBody] Contact contact)
        {
            myContactRepository.Add(contact);
        }
        [HttpPut]
        public void Put([FromBody] Contact contact)
        {
            myContactRepository.Edit(contact);
        }
        [HttpDelete]
        public void Delete(int Id)
        {
            myContactRepository.Delete(Id);
        }
    }
}
