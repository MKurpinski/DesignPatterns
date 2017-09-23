using System.Collections.Generic;

namespace DesignPatterns.Strategy.Strategies
{
    public interface ISortingStrategy<T>
    {
        IEnumerable<T> Sort(IEnumerable<T> dataToSort);
    }
}
