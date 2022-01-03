using Model;
using System;
using System.Collections.Generic;

namespace DataStore
{
    public class ContactData
    {
        public List<Contact> ContactsList { get; set; } = new List<Contact> {
            new Contact (){
                Id=1,Name="Smith John", Company="XYZ", BirthDate="09/09/1999", Email="abc@y.com", MobilePhone="666-666-6666", WorkPhone="123-456-7890", Address=new Address(){ Line1="123 Dr",Line2="Apt 12", City="ABC", State="XY", Country="USA", Zipcode="12345"}
            },
            new Contact (){
               Id=2, Name="Ryan Jacob", Company="ABC", BirthDate="09/09/1999", Email="xyz@y.com", MobilePhone="555-555-5555", WorkPhone="000-000-0000", Address=new Address(){ Line1="abc Dr",Line2="Apt 90", City="BNM", State="YO", Country="USA", Zipcode="12345"}
            }
        };
    }
}
