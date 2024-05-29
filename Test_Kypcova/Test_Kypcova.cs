using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Khalin_Kypcova_612pst.Classes;
using Type = Khalin_Kypcova_612pst.Classes.Type;

namespace Test_Kypcova
{
    [TestClass]
    public class Test_Kypcova
    {
        [TestMethod]
        public void Test_Constructin_Admin()
        {
            int id = 1;
            string name = "test";
            string email = "test@mail.com";
            string password = "password";
            string phone = "1234567890";
            string expected = id.ToString() + email + name + password + phone;

            Admin admin = new Admin(id,email,name,password,phone);
            string actual = admin.Id.ToString() + admin.Email + admin.Name + admin.Password + admin.Phone;

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void Test_Constructin_Order()
        {
            int id = 1;
            string name = "test";
            string email = "test@mail.com";
            string password = "password";
            string phone = "1234567890";
            Guest guest = new Guest(id, email, name, password, phone);
            Type type = (Type)2;
            string expected = id.ToString() + name + type.ToString() + DateTime.Now.Date;

            Order order = new Order(id, guest, type, DateTime.Now.Date);
            string actual = order.Id.ToString() + order.user.Name + order.type + order.Date;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Constructin_Guest()
        {
            int id = 1;
            string name = "test";
            string email = "test@mail.com";
            string password = "password";
            string phone = "1234567890";
            string expected = id.ToString() + email + name + password + phone;

            Guest guest = new Guest(id, email, name, password, phone);
            string actual = guest.Id.ToString() + guest.Email + guest.Name + guest.Password + guest.Phone;

            Assert.AreEqual(expected, actual);
        }
    }
}
