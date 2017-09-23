using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Strategies
{
    public class QuickSortStrategy<T>: ISortingStrategy<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> dataToSort)
        {
            Console.WriteLine("Sorting data with QuickSort");
            return dataToSort;
        }
    }
}
