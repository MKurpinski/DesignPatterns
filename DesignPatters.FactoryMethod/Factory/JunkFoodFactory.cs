using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatters.FactoryMethod.Food;

namespace DesignPatters.FactoryMethod.Factory
{
    public class JunkFoodFactory: IFoodFactory
    {
        public IFood GetFood()
        {
            return new Hamburger();
        }
    }
}
