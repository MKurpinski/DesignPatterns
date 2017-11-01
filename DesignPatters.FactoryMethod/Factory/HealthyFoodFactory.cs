using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatters.FactoryMethod.Food;

namespace DesignPatters.FactoryMethod.Factory
{
    public class HealthyFoodFactory: IFoodFactory
    {
        public IFood GetFood()
        {
            return new Salad();
        }
    }
}
