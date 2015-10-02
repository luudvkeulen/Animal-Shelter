using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace Animal_Shelter_Test
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Dog dog = new Dog("123456", new SimpleDate(01, 05, 1997), "Peter", new SimpleDate(02, 06, 2011));
            Assert.AreEqual(dog.ChipRegistrationNumber, "12345");
            Assert.AreEqual(dog.DateOfBirth.Day, 01);
            Assert.AreEqual(dog.DateOfBirth.Month, 05);
            Assert.AreEqual(dog.DateOfBirth.Year, 1997);
            Assert.AreEqual(dog.LastWalkDate.Day, 02);
            Assert.AreEqual(dog.LastWalkDate.Month, 06);
            Assert.AreEqual(dog.LastWalkDate.Year, 2011);
            Assert.AreEqual(dog.IsReserved, false);
            Assert.AreEqual(dog.Name, "Peter");
            Assert.AreEqual(dog.Price, 200);

            dog.IsReserved = true;
            Assert.AreEqual(true, dog.IsReserved);

            dog = new Dog("51000", new SimpleDate(01, 05, 1997), "Peter", new SimpleDate(02, 06, 2011));
            Assert.AreEqual(350, dog.Price);
        }
    }
}
