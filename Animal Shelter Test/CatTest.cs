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

            cat = new Cat("12345", new SimpleDate(12, 03, 2015), "Henk", "Pees everywhere. Bad cat and does not listen really well. Also bites everyone he sees");
            Assert.AreEqual(cat.BadHabits, "Pees everywhere. Bad cat and does not listen really well. Also bites everyone he sees");
            Assert.AreEqual(cat.Price, 20);

            cat.IsReserved = true;
            Assert.AreEqual(cat.IsReserved, true);
        }

        [TestMethod]
        public void TestToString()
        {
            Cat cat = new Cat("123", new SimpleDate(12, 03, 2015), "Henk", "Pees everywhere");
            string catstring = cat.ToString();
            Assert.AreEqual(catstring, "00123, 12-03-2015, Henk, not reserved, 45, Pees everywhere");

            cat = new Cat("12345", null, "", "");
            cat.IsReserved = true;
            catstring = cat.ToString();
            Assert.AreEqual(catstring, "12345, 00-00-0000, noname, reserved, 60, ");
        }
    }
}
