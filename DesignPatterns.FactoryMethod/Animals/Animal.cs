
namespace DesignPatterns.SimpleFactory.Animals
{
    public abstract class Animal
    {
        public string Type => GetType().Name;
    }
}