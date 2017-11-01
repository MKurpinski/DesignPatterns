using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatters.FactoryMethod.Food
{
    public interface IFood
    {
        int NumberOfCalories { get; }
        string Name { get; }
        string Description { get; }
    }
}
