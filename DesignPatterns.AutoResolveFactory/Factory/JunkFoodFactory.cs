using DesignPatterns.AutoResolveFactory.Food;

namespace DesignPatterns.AutoResolveFactory.Factory
{
    public class JunkFoodFactory: IFoodFactory
    {
        public FoodType Type => FoodType.Junk;

        public IFood GetFood()
        {
            return new Hamburger();
        }
    }
}
