using DAL;
using Model;
using System;
using System.Collections.Generic;

namespace ContactRepository
{
    public class MyContactRepository : IContactRepository
    {
        ContactDataService service = new ContactDataService();
        public void Add(Contact contact)
        {
            service.Add(contact);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public void Edit(Contact contact)
        {
            service.Edit(contact);
        }

        public Contact GetContact(int id)
        {
            return service.GetContact(id);
        }

        public Contact GetContactByEmailPhoneNumber(string EmailPhoneNo)
        {
            return service.GetContactByEmailPhoneNumber(EmailPhoneNo);
        }

        public List<Contact> GetContacts()
        {
            return service.GetContacts();
        }

        public List<Contact> GetContactsByStateCity(string StateCity)
        {
            return service.GetContactsByStateCity(StateCity);
        }
    }
}
