using DesignPatterns.AutoResolveFactory.Food;

namespace DesignPatterns.AutoResolveFactory.Factory
{
    public class HealthyFoodFactory: IFoodFactory
    {
        public FoodType Type => FoodType.Healthy;

        public IFood GetFood()
        {
            return new Salad();
        }
    }
}
