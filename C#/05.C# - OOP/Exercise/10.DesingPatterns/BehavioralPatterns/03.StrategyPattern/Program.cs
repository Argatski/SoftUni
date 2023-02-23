using _03.StrategyPattern;
using _03.StrategyPattern.Strategies;
using System.Reflection;

string sortType = Console.ReadLine();
Console.WriteLine();

var strategyType = Assembly.GetEntryAssembly()
    .GetTypes()
    .Where(t => typeof(ISortingStrategy).IsAssignableFrom(t) && t.Name.StartsWith(sortType))
    .FirstOrDefault();

ISortingStrategy strategy = (ISortingStrategy)Activator.CreateInstance(strategyType);

Sorter sorter = new Sorter(strategy);
sorter.Sort(new List<int> { 1, 5, 2, 3, 7, 8, 10 });