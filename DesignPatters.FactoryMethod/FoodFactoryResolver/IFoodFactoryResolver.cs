using DesignPatters.FactoryMethod.Factory;

namespace DesignPatters.FactoryMethod.FoodFactoryResolver
{
    public interface IFoodFactoryResolver
    {
        IFoodFactory Resolve(FoodType type);
    }
}
