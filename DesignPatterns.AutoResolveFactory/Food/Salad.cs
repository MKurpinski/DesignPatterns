namespace DesignPatterns.AutoResolveFactory.Food
{
    public class Salad: IFood
    {
        public int NumberOfCalories => 200;
        public string Name => "Salad";
        public string Description => $"Healthy food. Ideal for everyday meal. It's {Name}. Calories: {NumberOfCalories}";
    }
}
