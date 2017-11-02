namespace DesignPatterns.AutoResolveFactory.Food
{
    public class Hamburger: IFood
    {
        public int NumberOfCalories => 1200;
        public string Name => "Hamburger";
        public string Description => $"Junk food. Ideal for cheat meal. It's {Name}. Calories: {NumberOfCalories}";
    }
}
