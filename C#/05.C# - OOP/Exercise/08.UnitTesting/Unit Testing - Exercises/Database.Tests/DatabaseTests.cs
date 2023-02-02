namespace Database.Tests
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private const int ArraySize = 16;
        private const int ArrayIndex = 0;
        [Test]
        public void EmptyConstructorShouldInitalazedData()
        {
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            //Arrage
            Database database = new Database(numbers);
            //Action
            var actualResult = database.Count;

            //Assert
            Assert.AreEqual(ArraySize, actualResult);
        }

        [Test]
        public void AddOperationShouldAddAnElementAtTheNextFreeCell()
        {
            //Arrage
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Database db = new Database(numbers);

            //Action
            db.Add(5);
            var allElements = db.Fetch();

            //Assert
            var expectedValue = 5;
            var actuialValue = allElements[10];

            Assert.AreEqual(expectedValue, actuialValue);
        }

        [Test]
        public void IfThereAre16ElementsInTheDatabaseAndTryToAdd17thElement()
        {
            //Arrage
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            Database db = new Database(numbers);


            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(20));
        }

        [Test]
        public void RemoveOperationShouldSupportOnlyRemovingAnElementAtTheLastIndex()
        {
            //Arrage
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Database db = new Database(numbers);

            //Action
            db.Remove();

            //Assert
            var expectedResult = 9;
            var actulaResult = db.Count;

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void IfYouTryToRemoveElementFromEmptyDatabase()
        {
            //Arrage
            Database db = new Database();

            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void FetchMethodShouldReturnTheElementsAsArray()
        {
            //Arrage
            int[] numbers = Enumerable.Range(1, 5).ToArray();
            Database db = new Database(numbers);

            //Action
            var allItems = db.Fetch();
            int[] expValues = { 1, 2, 3, 4, 5 };

            //Assert
            CollectionAssert.AreEqual(allItems, expValues);
        }
    }
}
