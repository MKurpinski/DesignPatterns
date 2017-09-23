using System;
using DesignPatterns.SimpleFactory.Animals;
using DesignPatterns.SimpleFactory.Factories;
using NUnit.Framework;

namespace DesignPatterns.SimpleFactory.Tests
{
    [TestFixture]
    public class AnimalFactoryTests
    {
        [Test]
        public void TheBiggestWaterAnimal_ShouldBeWhale()
        {
            var factory = new AnimalFactory();

            Animal result = factory.GetTheBiggestAnimal(PlaceOfOccurence.Water);

            Assert.IsNotNull(result as Whale);
            
        }

        [Test]
        public void TheBiggestLandAnimal_ShouldBeElephant()
        {
            var factory = new AnimalFactory();

            Animal result = factory.GetTheBiggestAnimal(PlaceOfOccurence.Land);

            Assert.IsNotNull(result as Elephant);
        }

        [Test]
        public void TheBiggestAirAnimal_ShouldBePelican()
        {
            var factory = new AnimalFactory();

            Animal result = factory.GetTheBiggestAnimal(PlaceOfOccurence.Air);

            Assert.IsNotNull(result as Pelican);
        }
    }
}