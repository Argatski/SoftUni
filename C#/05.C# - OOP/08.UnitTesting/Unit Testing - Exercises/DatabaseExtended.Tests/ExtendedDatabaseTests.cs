
namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.ComponentModel;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            var people = new Person[]
                 {
                    new Person(1, "Pesho"),
                new Person(2, "Gosho"),
                new Person(3, "Ivan_Ivan"),
                new Person(4, "Pesho_ivanov"),
                new Person(5, "Gosho_Naskov"),
                new Person(6, "Pesh-Peshov"),
                new Person(7, "Ivan_Kaloqnov"),
                new Person(8, "Ivan_Draganchov"),
                new Person(9, "Asen"),
                new Person(10, "Jivko"),
                new Person(11, "Toshko")
                 };
            this.database = new Database(people);
        }


        [Test]
        public void DatabaseCountShouldWorkCorrectly()
        {
            //Action
            var expResult = 11;
            var actualResult = database.Count;

            //Assert
            Assert.AreEqual(expResult, actualResult);

        }

        [Test]
        public void DatabaseAddMethodsShouldWorkCorrectly()
        {
            //Arrage
            var person = new Person(12, "Mishaka");

            //Acction
            this.database.Add(person);

            var expResult = 12;
            var actualResult = database.Count;

            //Assert
            Assert.AreEqual(expResult, actualResult);
        }

        [Test]
        public void DatabaseAddMethodShouldThrowExceptionIfCapacityIsOverflown()
        {
            //Arrage
            var person1 = new Person(12, "John");
            var person2 = new Person(13, "Paul");
            var person3 = new Person(14, "Green");
            var person4 = new Person(15, "Brown");
            var person5 = new Person(16, "Killer");

            this.database.Add(person1);
            this.database.Add(person2);
            this.database.Add(person3);
            this.database.Add(person4);
            this.database.Add(person5);

            //Action-Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(17, "Destroyer")));
        }

        [Test]
        public void DatabaseShouldThrowExceptionIfPersonWithSameUsernameIsAdded()
        {
            //Arrage
            var person = new Person(12/*isn`t corect*/, "Gosho"/*duplicated*/);

            //Action-Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));

        }

        [Test]
        public void DatabaseShouldThrowExceptionIfPersonWithSameIdIsAdded()
        {
            //Arrage
            var person = new Person(2, "John");

            //Action-Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));
        }

        [Test]
        public void MethodRemoveWorkCorrectly()
        {
            //Arrage-Action
            this.database.Remove();
            var expCount = 10;
            var actualCount = this.database.Count;

            //Assert
            Assert.AreEqual(expCount, actualCount);
        }
    }
}

