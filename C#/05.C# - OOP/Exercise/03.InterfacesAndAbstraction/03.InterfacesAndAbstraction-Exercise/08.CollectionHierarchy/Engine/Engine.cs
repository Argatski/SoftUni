namespace CollectionHierarchy.Engine
{
    using System;
    using Contracts;
    using System.Collections.Generic;

    public class Engine
    {
        private readonly IAddCollections addCollection;
        private readonly IAddRemoveCollection addRemoveCollection;
        private readonly IMyList myList;

        public Engine(
            IAddCollections addCollections, IAddRemoveCollection addRemoveCollections, IMyList myLists)
        {
            this.addCollection = addCollections;
            this.addRemoveCollection = addRemoveCollections;
            this.myList = myLists;
        }

        public void Run()
        {
            var input = Console.ReadLine().Split();
            int removeOperationsCount = int.Parse(Console.ReadLine());

            this.PrintResults(input, removeOperationsCount);
        }

        private void PrintResults(string[] input, int removeOperationsCount)
        {
            this.PrintAddedResults(input, this.addCollection);
            this.PrintAddedResults(input, this.addRemoveCollection);
            this.PrintAddedResults(input, this.myList);

            this.PrintRemovedResults(removeOperationsCount, this.addRemoveCollection);
            this.PrintRemovedResults(removeOperationsCount, this.myList);
        }

        private void PrintRemovedResults(int removeOperationsCount, IAddRemoveCollection removeCollection)
        {
            var removedResult = new List<string>();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                removedResult.Add(removeCollection.Remove());
            }
            Console.WriteLine(string.Join(" ", removedResult));
        }

        private void PrintAddedResults(string[] input, IAddCollections collections)
        {
            var addedResult = new List<int>();

            foreach (var text in input)
            {
                addedResult.Add(collections.Add(text));

            }
            Console.WriteLine(string.Join(" ", addedResult));
        }
    }
}
