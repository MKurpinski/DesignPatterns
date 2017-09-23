using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int> {1, 42, 1, 3, 4, 1};
            var intSorter = new IntSorter();
            Console.WriteLine("Using the default strategy");
            intSorter.SortIntegers(list);
            Console.WriteLine("\nChanging the sorting strategy");
            intSorter.ChangeSortingStrategy(new MergeSortStrategy<int>());
            intSorter.SortIntegers(list);
            Console.ReadLine();
        }
    }
}
