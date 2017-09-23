using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Decorator.Pizzas;
using NUnit.Framework;

namespace DesignPatterns.Decorator
{
    [TestFixture]
    class PizzasTest
    {
        private IPizza _basePizza;

        [SetUp]
        public void SetUpTests()
        {
            _basePizza = new BasePizza();
        }

        [Test]
        public void PizzaWithHam_ShouldHaveProperCost()
        {
            var pizzaWithHam = new PizzaWithHam(_basePizza);
            var expectedCost = _basePizza.Cost + 3;

            var actualCost = pizzaWithHam.Cost;

            Assert.AreEqual(expectedCost, actualCost);
        }

        [Test]
        public void PizzaWithHam_ShouldHaveProperIngredients()
        {
            var pizzaWithHam = new PizzaWithHam(_basePizza);
            var expectedIngredients = _basePizza.Ingredients;
            expectedIngredients.Add("Ham");

            var actualIngredients = pizzaWithHam.Ingredients;

            Assert.That(actualIngredients, Is.EquivalentTo(expectedIngredients));
        }

        [Test]
        public void PizzaWithDoubleHam_ShouldHaveProperIngredients()
        {
            var pizzaWithHam = new PizzaWithHam(_basePizza);
            var pizzaWithDoubleHam = new PizzaWithHam(pizzaWithHam);
            var expectedIngredients = pizzaWithHam.Ingredients;
            expectedIngredients.Add("Ham");

            var actualIngredients = pizzaWithDoubleHam.Ingredients;

            Assert.That(actualIngredients, Is.EquivalentTo(expectedIngredients));
        }
        [Test]
        public void PizzaWithDouble_ShouldHaveProperCost()
        {
            var pizzaWithHam = new PizzaWithHam(_basePizza);
            var pizzaWithDoubleHam = new PizzaWithHam(pizzaWithHam);
            var expectedCost = pizzaWithHam.Cost + 3;

            var actualCost = pizzaWithDoubleHam.Cost;

            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
