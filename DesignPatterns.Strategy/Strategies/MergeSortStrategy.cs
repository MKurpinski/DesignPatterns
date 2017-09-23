using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Strategies
{
    public class MergeSortStrategy<T>: ISortingStrategy<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> dataToSort)
        {
            Console.WriteLine("Sorting data with MergeSort");
            return dataToSort;
        }
    }
}
