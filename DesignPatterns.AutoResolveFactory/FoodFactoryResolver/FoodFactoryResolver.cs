using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.AutoResolveFactory.Factory;

namespace DesignPatterns.AutoResolveFactory.FoodFactoryResolver
{
    public class FoodFactoryResolver: IFoodFactoryResolver
    {
        private readonly IEnumerable<IFoodFactory> _factories;

        public FoodFactoryResolver(IEnumerable<IFoodFactory> factories)
        {
            _factories = factories;
        }

        public IFoodFactory Resolve(FoodType type)
        {
            var factory = _factories.FirstOrDefault(x => x.Type == type);
            return factory ?? throw new InvalidOperationException();
        }
    }
}
