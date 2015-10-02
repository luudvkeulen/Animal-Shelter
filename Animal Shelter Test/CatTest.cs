using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace Animal_Shelter_Test
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Cat cat = new Cat("123456", new SimpleDate(01, 05, 1997), "Gerrit", "");
            Assert.AreEqual(cat.ChipRegistrationNumber, "12345");
            Assert.AreEqual(cat.DateOfBirth.Day, 01);
            Assert.AreEqual(cat.DateOfBirth.Month, 05);
            Assert.AreEqual(cat.DateOfBirth.Year, 1997);
            Assert.AreEqual(cat.BadHabits, "");
            Assert.AreEqual(cat.IsReserved, false);
            Assert.AreEqual(cat.Name, "Gerrit");
            Assert.AreEqual(cat.Price, 60);

            cat = new Cat("123", new SimpleDate(12, 03, 2015), "Henk", "Pees everywhere");
            Assert.AreEqual(cat.ChipRegistrationNumber, "00123");
            Assert.AreEqual(cat.DateOfBirth.Day, 12);
            Assert.AreEqual(cat.DateOfBirth.Month, 03);
            Assert.AreEqual(cat.DateOfBirth.Year, 2015);
            Assert.AreEqual(cat.BadHabits, "Pees everywhere");
            Assert.AreEqual(cat.IsReserved, false);
            Assert.AreEqual(cat.Name, "Henk");
            Assert.AreEqual(cat.Price, 45);
        }
    }
}
