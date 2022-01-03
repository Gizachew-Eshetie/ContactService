using System;

namespace Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public byte ProfileImage { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public Address Address { get; set; }     

    }
}
