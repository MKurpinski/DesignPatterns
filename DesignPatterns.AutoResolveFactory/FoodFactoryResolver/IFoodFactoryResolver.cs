using DesignPatterns.AutoResolveFactory.Factory;

namespace DesignPatterns.AutoResolveFactory.FoodFactoryResolver
{
    public interface IFoodFactoryResolver
    {
        IFoodFactory Resolve(FoodType type);
    }
}
