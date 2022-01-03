using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactRepository
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();
        Contact GetContact(int id);
        List<Contact> GetContactsByStateCity(string StateCity);
        Contact GetContactByEmailPhoneNumber(string EmailPhoneNo);
        void Add(Contact contact);
        void Edit(Contact contact);
        void Delete(int id);


    }
}
