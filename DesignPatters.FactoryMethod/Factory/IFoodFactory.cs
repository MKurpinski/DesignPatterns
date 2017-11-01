using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatters.FactoryMethod.Food;

namespace DesignPatters.FactoryMethod.Factory
{
    public interface IFoodFactory
    {
        IFood GetFood();
    }
}
