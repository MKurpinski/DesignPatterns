using DesignPatterns.SimpleFactory.Animals;

namespace DesignPatterns.SimpleFactory.Factories
{
    public interface IAnimalFactory
    {
        Animal GetTheBiggestAnimal(PlaceOfOccurence type);
    }
}
