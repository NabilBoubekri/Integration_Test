using Telerik.JustMock;
using Test_Unitaire_1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Moq;

namespace Test_Unitaire_1_TestClasse
{
    [TestClass]
    public class UnitTest1
    {
        /*[TestMethod]
        public void TestMethod1()
        {
            Calculatrice calculatrice = new Calculatrice();
            Assert.AreEqual(calculatrice.add(4, 2), 6);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Calculatrice calculatrice = new Calculatrice();
            Assert.AreEqual(calculatrice.sub(10, 2), 8);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Calculatrice calculatrice = new Calculatrice();
            Assert.AreEqual(calculatrice.mul(5, 5), 25);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Calculatrice calculatrice = new Calculatrice();
            Assert.AreEqual(calculatrice.div(10, 2), 5);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Calculatrice calculatrice = new Calculatrice();
            int[] test = { 1, 2, 3 };
            Assert.AreEqual(calculatrice.avg(test), 2);
        }*/
        /*[TestMethod]
        public void TestMethod6()
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(365)*14);
            User user = new User("User@gmail.com", "UserName", "UserLastName", date);
            Assert.AreEqual(true, user.isValid());
        }*/
        [TestMethod]
        public void TestValidUser()
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(365) * 14);
            User user = new User("User@gmail.com", "UserName", "UserLastName", date,"aLABALALA1");
            Assert.AreEqual(true, user.isValid());
        }
        [TestMethod]
        public void TestAddItem()
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(365) * 14);
            User user = new User("User@gmail.com", "UserName", "UserLastName", date, "aLABALALA1");
            Item item = new Item("Repas", "Il faut faire à manger");
            Assert.IsTrue(user.add(item));
        }
        [TestMethod]
        public void TestAddItem2()
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(365) * 14);
            User user = new User("User@gmail.com", "UserName", "UserLastName", date, "aLABALALA1");
            Item item = new Item("Repas", "Il faut faire à manger");
            Item item2 = new Item("Repaas", "Il faut faire à manger");
            user.add(item2);
            Assert.IsFalse(user.add(item));
        }
        [TestMethod]
        public void TestSave()
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(365) * 14);
            User user = new User("User@gmail.com", "UserName", "UserLastName", date, "aLABALALA1");
            Item item = new Item("Repas", "Il faut faire à manger");
            user.add(item);
            Assert.ThrowsException<InvalidOperationException>(()=>user.save());
        }
        [TestMethod]
        public void TestSave2()
        {
            var mock = new Mock<User>() { CallBase = true };

            // Arrange la méthode save pour qu'elle retourne true
            mock.Setup(x => x.save()).Returns(true);

            // Teste le mock
            Assert.IsTrue(mock.Object.save());

            // Teste le comportement original de isValid
            //Assert.IsTrue(mock.Object.isValid());
        }
        [TestMethod]
        public void TestSave3()
        {
            var mock = new Mock<User>() { CallBase = true };
            mock.Setup(x => x.save()).Returns(true);
            mock.Object.email = "User@gmailcom";
            mock.Object.prenom = "UserName";
            mock.Object.nom = "UserLastName";
            mock.Object.password = "aLABALALA123";
            mock.Object.date_Naissance = DateTime.Now.Subtract(TimeSpan.FromDays(365) * 14);
            Assert.IsTrue(mock.Object.isValid());
        }

        [TestMethod]
        public void testSendEMail()
        {
            var mock = new Mock<User>() { CallBase = true };
            mock.Setup(x => x.sendEmail()).Returns(true);
            Assert.IsTrue(mock.Object.sendEmail());
        }
    }
}