using System;
using DesignPatterns.SimpleFactory.Animals;

namespace DesignPatterns.SimpleFactory.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal GetTheBiggestAnimal(PlaceOfOccurence type)
        {
            switch (type)
            {
                case PlaceOfOccurence.Air:
                    {
                        return new Pelican();
                    }
                case PlaceOfOccurence.Land:
                    {
                        return new Elephant();
                    }
                case PlaceOfOccurence.Water:
                    {
                        return new Whale();
                    }
                default:
                    {
                        throw new InvalidOperationException();
                    }
            }
        }
    }
}
