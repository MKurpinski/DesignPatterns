using System.Collections.Generic;
using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy
{
    public class IntSorter
    {
        private ISortingStrategy<int> _sortingStrategy;

        public IntSorter(ISortingStrategy<int> sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }
        public IntSorter()
        {
            _sortingStrategy = new QuickSortStrategy<int>();
        }

        public void ChangeSortingStrategy(ISortingStrategy<int> sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public IEnumerable<int> SortIntegers(IEnumerable<int> integers)
        {
            return _sortingStrategy.Sort(integers);
        }
    }
}
