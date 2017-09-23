using System.Collections.Generic;

namespace DesignPatterns.Decorator.Pizzas
{
    public class BasePizza: IPizza
    {
        public decimal Cost { get; set; }
        public IList<string> Ingredients { get; set; } = new List<string>();

        public BasePizza()
        {
            AdjustPizza();
        }
        private void AdjustPizza()
        {
            Cost = 10;
            Ingredients.Add("Sauce");
            Ingredients.Add("Cheese");
        }
    }
}
