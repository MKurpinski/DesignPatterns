

using DesignPatterns.AutoResolveFactory.Food;

namespace DesignPatterns.AutoResolveFactory.Factory
{
    public interface IFoodFactory
    {
        FoodType Type { get; }
        IFood GetFood();
    }
}
