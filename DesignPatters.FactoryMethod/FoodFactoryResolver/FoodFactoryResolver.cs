using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatters.FactoryMethod.Factory;

namespace DesignPatters.FactoryMethod.FoodFactoryResolver
{
    public class FoodFactoryResolver: IFoodFactoryResolver
    {
        public IFoodFactory Resolve(FoodType type)
        {
            switch (type)
            {
                case FoodType.Healthy:
                {
                    return new HealthyFoodFactory();
                }
                case FoodType.Junk:
                {
                    return new JunkFoodFactory();
                }
                default:
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
