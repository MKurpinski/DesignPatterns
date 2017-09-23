using System.Collections.Generic;

namespace DesignPatterns.Decorator.Pizzas
{
    public class PizzaWithJalapeno : IPizza
    {
        public decimal Cost { get; set; }
        public IList<string> Ingredients { get; set; } = new List<string>();
        private readonly IPizza _decoratedPizza;

        public PizzaWithJalapeno(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            AdjustPizza();
        }

        private void AdjustPizza()
        {
            Cost = _decoratedPizza.Cost + 2;
            Ingredients.Add("Jalapeno");
            foreach (var ingredient in _decoratedPizza.Ingredients)
            {
                Ingredients.Add(ingredient);
            }
        }

    }
}
