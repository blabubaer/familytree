using FamilyTree;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FamilyTreeTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) F�dt: 2000 D�d: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);

        }
        [TestMethod]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [TestMethod]
        public void TestFewFields()
        {
            var p = new Person
            {
                Id = 5,
                FirstName = "Christoffer",
                BirthYear = 1987
            };
            var actualDescription = p.GetDescription();
            var expectedDescription = "Christoffer (Id=5) F�dt: 1987";

            Assert.AreEqual(expectedDescription,actualDescription);
        }
    }
}
