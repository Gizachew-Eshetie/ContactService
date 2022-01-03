using ContactRepository;
using ContactService.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using Newtonsoft.Json.Linq;

namespace ContactServiceUnitTests
{
    [TestClass]
    public class ContactControllerUnitTest
    {
        [TestMethod]
        public void GetContactById()
        {
            //Arrange
            var mock = new Mock<IContactRepository>();
            Contact testcon = new Contact()
            {
                Id = 1,
                Name = "Smith John",
                Company = "XYZ",
                BirthDate = "09/09/1999",
                Email = "abc@y.com",
                MobilePhone = "666-666-6666",
                WorkPhone = "123-456-7890",
                Address = new Address() { Line1 = "123 Dr", Line2 = "Apt 12", City = "ABC", State = "XY", Country = "USA", Zipcode = "12345" }
            };
            mock.Setup(p => p.GetContact(1)).Returns(testcon);

            //Act
            ContactController contact = new ContactController(mock.Object);
            Microsoft.AspNetCore.Mvc.JsonResult result = contact.Get(1);
            var con = result?.Value as Contact;

            //Assert
            Assert.AreEqual(testcon, con);
        }
    }
}
