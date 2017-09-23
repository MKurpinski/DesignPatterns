using System.Collections.Generic;

namespace DesignPatterns.Decorator.Pizzas
{
    public class PizzaWithHam: IPizza
    {
        public decimal Cost { get; set; }
        public IList<string> Ingredients { get; set; } = new List<string>();
        private readonly IPizza _decoratedPizza;

        public PizzaWithHam(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            AdjustPizza();
        }

        private void AdjustPizza()
        {
            Cost = _decoratedPizza.Cost + 3;
            Ingredients.Add("Ham");
            foreach (var ingredient in _decoratedPizza.Ingredients)
            {
                Ingredients.Add(ingredient);
            }
        }
    }
}
