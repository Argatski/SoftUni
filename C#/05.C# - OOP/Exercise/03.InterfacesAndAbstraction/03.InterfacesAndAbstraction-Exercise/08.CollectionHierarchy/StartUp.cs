using System;
using CollectionHierarchy.Engine;

namespace CollectionHierarchy
{

    using CollectionHierarchy.Models;
    using Engine;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            Engine.Engine engine = new Engine.Engine(addCollection, addRemoveCollection, myList);
            engine.Run();
        }
    }
}
