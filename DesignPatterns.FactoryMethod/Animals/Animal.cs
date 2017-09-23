
namespace DesignPatterns.SimpleFactory.Animals
{
    public abstract class Animal
    {
        public virtual string Type => GetType().Name;
    }
}