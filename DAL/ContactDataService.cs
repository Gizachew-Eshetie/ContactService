using DataStore;
using Model;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class ContactDataService
    {
        private readonly static ContactData contactData = new ContactData();
        public void Add(Contact contact)
        {
            contactData.ContactsList.Add(contact);
        }
        public Contact GetContact(int id)
        {
            return contactData.ContactsList.Find(c => c.Id == id); ;
        }
        public void Delete(int id)
        {
            Contact contact = contactData.ContactsList.Find(c => c.Id == id);
            contactData.ContactsList.Remove(contact);
        }

        public void Edit(Contact contact)
        {
            Contact cont = contactData.ContactsList.Find(c => c.Id == contact.Id);
            contactData.ContactsList.Remove(cont);
            cont = contact;
            contactData.ContactsList.Add(contact);
        }

        public Contact GetContactByEmailPhoneNumber(string EmailPhoneNo)
        {
            Contact contact = contactData.ContactsList.Find(c => c.Email == EmailPhoneNo || c.WorkPhone == EmailPhoneNo || c.MobilePhone == EmailPhoneNo);
            return contact;
        }

        public List<Contact> GetContacts()
        {
            return contactData.ContactsList;
        }

        public List<Contact> GetContactsByStateCity(string StateCity)
        {
            List<Contact> contacts = contactData.ContactsList.FindAll(c => c.Address?.State == StateCity || c.Address?.City == StateCity);
            return contacts;
        }
    }
}
