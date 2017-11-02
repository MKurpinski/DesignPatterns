namespace DesignPatterns.AutoResolveFactory.Food
{
    public interface IFood
    {
        int NumberOfCalories { get; }
        string Name { get; }
        string Description { get; }
    }
}
